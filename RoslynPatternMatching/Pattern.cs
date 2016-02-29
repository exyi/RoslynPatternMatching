using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynPatternMatching
{
    public abstract class Pattern
    {
        private List<Func<SyntaxNode, MatchContext, bool>> conditions;

        public virtual Pattern AddCondition(Predicate<SyntaxNode> condition)
        {
            AddCondition((n, m) => condition(n));
            return this;
        }

        public virtual Pattern AddCondition(Func<SyntaxNode, MatchContext, bool> condition)
        {
            if (conditions == null) conditions = new List<Func<SyntaxNode, MatchContext, bool>>();
            conditions.Add(condition);
            return this;
        }

        public virtual bool DoMatch(SyntaxNode node, MatchContext match)
        {
            return DoMatchType(node) && DoMatchCore(node) && conditions.All(c => c(node, match));
        }

        protected virtual bool DoMatchCore(SyntaxNode node)
        {
            return true;
        }

        protected virtual bool DoMatchType(SyntaxNode node) => true;
    }

    public class Pattern<TNode> :Pattern where TNode: SyntaxNode
    {
        public virtual Pattern<TNode> AddCondition(Predicate<TNode> condition)
        {
            base.AddCondition((n, m) => n is TNode && condition((TNode)n));
            return this;
        }

        public virtual Pattern<TNode> AddCondition(Func<TNode, MatchContext, bool> condition)
        {
            base.AddCondition((n, m) => n is TNode && condition((TNode)n, m));
            return this;
        }

        protected override bool DoMatchType(SyntaxNode node)
            => node is TNode;
    }

    //public class ForStatementPattern: Pattern
    //{

    //}
}
