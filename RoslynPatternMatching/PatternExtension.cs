using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynPatternMatching
{
    public static class PatternExtension
    {
        public static Pattern<T> AddIsKind<T>(this Pattern<T> pattern, SyntaxKind syntaxKind)
            where T : SyntaxNode
        {
            pattern.AddCondition(p => p.IsKind(syntaxKind));
            return pattern;
        }
    }
}
