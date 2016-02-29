using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatternNodeGenerator
{
    public class MatchingPropertyInfo
    {
        public NodeInfo PatternNode { get; set; }
        public string Name { get; set; }
        public PropertyInfo SyntaxProperty { get; set; }
    }
}
