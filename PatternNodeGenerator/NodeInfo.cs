using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternNodeGenerator
{
    public class NodeInfo
    {
        public static NodeInfo FromType(Type type)
        {
            return new NodeInfo
            {
                Type = type,
                Name = CreateName(type)
            };
        }

        public static string CreateName(Type type)
        {
            var n = type.Name;
            if (n.EndsWith("Syntax", StringComparison.Ordinal)) n = n.Remove(n.Length - "Syntax".Length);
            return n + "Pattern";
        }

        public Type Type { get; set; }
        public string Name { get; set; }
        public NodeInfo BaseType { get; set; }
        public NodeConditionMethod[] ConditionMethods { get; set; }
        public MatchingPropertyInfo[] MatchingProperties { get; set; }
    }
}
