using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatternNodeGenerator
{
    public class RoslynSyntaxNodeFinder
    {
        private static NodeInfo patternNodeInfo = new NodeInfo { Type = typeof(SyntaxNode), Name = "Pattern" };
        public IEnumerable<NodeInfo> CrawlNodes()
        {
            var baseType = typeof(SyntaxNode);
            var types = new[] { typeof(SyntaxNode).Assembly, typeof(ThisExpressionSyntax).Assembly }.SelectMany(a => a.GetTypes())
                .Where(t => baseType.IsAssignableFrom(t) && t.DeclaringType == null && t.IsPublic)
                .ToArray();
            var nodes = types.Select(NodeInfo.FromType).ToArray();
            var dict = nodes.ToDictionary(n => n.Type);
            SetBaseTypes(dict, nodes);
            foreach (var node in nodes)
            {
                node.ConditionMethods = GetConditionMethods(node);
                node.MatchingProperties = GetMatchingProperties(dict, node);
            }
            return nodes;
        }

        protected void SetBaseTypes(Dictionary<Type, NodeInfo> dict, NodeInfo[] nodes)
        {
            foreach (var n in nodes)
            {
                NodeInfo baseType = null;
                var t = n.Type.BaseType;
                while (t != null && !dict.TryGetValue(t, out baseType))
                    t = t.BaseType;
                n.BaseType = baseType;
            }
        }

        protected MatchingPropertyInfo[] GetMatchingProperties(Dictionary<Type, NodeInfo> dict, NodeInfo node)
        {
            return (from p in GetMatcherProperties(node.Type)
                    where DefinedExceptBase(p, node)
                    let patternType = dict[p.PropertyType]
                    select new MatchingPropertyInfo
                    {
                        Name = p.Name,
                        PatternNode = patternType,
                        SyntaxProperty = p
                    }
                   ).ToArray();
        }

        protected NodeConditionMethod[] GetConditionMethods(NodeInfo node)
        {
            return GetCheckerProperties(node.Type).Where(p => DefinedExceptBase(p, node))
                .Select(NodeConditionMethod.FromProperty)
                .ToArray();
        }

        protected bool DefinedExceptBase(PropertyInfo prop, NodeInfo node)
            => node.Type.BaseTypes().TakeWhile(t => t != node.BaseType?.Type).Contains(prop.DeclaringType);

        protected IEnumerable<PropertyInfo> GetCheckerProperties(Type type)
        {
            return type.GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(ObsoleteAttribute)));
        }

        protected IEnumerable<PropertyInfo> GetMatcherProperties(Type type)
        {
            return type.GetProperties()
                .Where(p => typeof(SyntaxNode).IsAssignableFrom(p.PropertyType) && !Attribute.IsDefined(p, typeof(ObsoleteAttribute)));
        }
    }
}
