using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternNodeGenerator
{
    public class PatternGenerator
    {
        public static void test()
        {
            
        }

        static string GenerateNodeCode(NodeInfo node)
        {
            var baseType = node.BaseType == null ? $"Pattern" : node.BaseType.Name;
            var matchers = node.MatchingProperties.Length == 0 ? "true" :
                string.Join(" && ", node.MatchingProperties.Select(m => GenerateMatchingPropertyMatcher(node, m)));
            return $@"
public static class {node.Name}PatternExtensions {{

{string.Concat(node.ConditionMethods.Select(s => GeneratePropertyConditionCode(node, s, true).Indent()))}
{string.Concat(node.ConditionMethods.Select(s => GeneratePropertyConditionCode(node, s, false).Indent()))}
{string.Concat(node.MatchingProperties.Select(s => GenerateMatchingPropertyDefinition(node, s).Indent()))}
}}
";
        }

        static string GeneratePropertyConditionCode(NodeInfo node, NodeConditionMethod conditionMethod, bool matchParam)
        {
            var argsTypes = string.Join(", ", conditionMethod.ArgumentProperties.Select(p => p.PropertyType.FormatType()));
            if (matchParam) argsTypes += ", MatchContext";
            var func = $"Func<{argsTypes}, bool>";
            var argAccess = string.Join(", ", conditionMethod.ArgumentProperties.Select(p => "n." + p.Name));
            string lamda = matchParam ?
                $@"(SyntaxNode sn, MatchContext m) => {{var n = ({node.Type.FormatType()})sn; return condition({argAccess}, m); }}":
                $@"(SyntaxNode sn) => {{ var n = ({node.Type.FormatType()})sn; return condition({argAccess}); }}";
            return ExtensionMethodHeader(conditionMethod.Name, node.Type,
                _ => $"{func} condition",
                t => $"pattern.AddCondition({lamda})");
        }

        static string GenerateMatchingPropertyDefinition(NodeInfo node, MatchingPropertyInfo m)
        {
            return
                ExtensionMethodHeader(
                    $"Add{m.Name}Pattern", node.Type,
                    _ => "Pattern propertyPattern",
                    t => $@"if(propertyPattern != null) pattern.AddCondition(({t} node, MatchContext match) => propertyPattern.DoMatch(node.{m.SyntaxProperty.Name}, match))");
            // TODO: SyntaxNode overload
        }

        static string ExtensionMethodHeader(string name, Type type, Func<string, string> args, Func<string, string> body)
        {
            var typeName = type.IsSealed ? type.FormatType() : "T";
            var a = args?.Invoke(typeName) ?? "";
            if (!string.IsNullOrEmpty(a)) a = ", " + a;
            var b = body?.Invoke(typeName) ?? "";
            if (typeName != "T")
            {

                return $@"
public static Pattern<{typeName}> {name}(this Pattern<{typeName}> pattern{a})
{{
    {b};
    return pattern;
}}";
            }
            else {
                return $@"
public static Pattern<T> {name}<T>(this Pattern<T> pattern{a})
    where T: {type.FormatType()}
{{
    {b};
    return pattern;
}}";
            }
        }

        static string GenerateMatchingPropertyMatcher(NodeInfo node, MatchingPropertyInfo m)
        {
            return $@"(this.{m.Name} == null ? true : this.{m.Name}.DoMatch(node.{m.SyntaxProperty.Name}))";
        }

        public static string GenerateCode()
        {
            var nodes = new RoslynSyntaxNodeFinder().CrawlNodes();
            return $@"
{ string.Concat(nodes.Select(n => GenerateNodeCode(n))) }
                ";
        }
    }

    public static class StringUtils
    {
        public static string Indent(this string str, int num = 4, char ch = ' ')
        {
            var indent = "\n" + new string(ch, num);
            return str.Replace("\n", indent);
        }
    }
}
