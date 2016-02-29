using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternNodeGenerator
{
    public static  class ReflectionUtils
    {
        public static IEnumerable<Type> BaseTypes(this Type type)
        {
            var b = type;
            while(b != null)
            {
                yield return b;
                b = b.BaseType;
            }
        }

        public static string FormatType(this Type type)
        {
            if(type.IsConstructedGenericType)
            {
                var name = type.Name;
                var bti = name.IndexOf('`');
                if (bti >= 0) name = name.Remove(bti);
                return $"{type.Namespace}.{name}<{string.Join(", ", type.GetGenericArguments().Select(FormatType))}>";
            }
            return type.FullName;
        }
    }
}
