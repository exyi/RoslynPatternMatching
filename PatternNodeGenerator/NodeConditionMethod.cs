using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PatternNodeGenerator
{
    public class NodeConditionMethod
    {
        public PropertyInfo[] ArgumentProperties { get; set; }
        public string Name { get; set; }

        public static NodeConditionMethod FromProperty(PropertyInfo prop)
        {
            return new NodeConditionMethod
            {
                ArgumentProperties = new[] { prop },
                Name = $"Add{prop.Name}Condition"
            };
        }
    }
}
