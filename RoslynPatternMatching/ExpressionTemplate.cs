
using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
namespace RoslynPatternMatching {
	

public static class SyntaxNodePatternPatternExtensions {


    public static Pattern<T> AddRawKindCondition<T>(this Pattern<T> pattern, Func<System.Int32, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.RawKind, m); });
        return pattern;
    }
    public static Pattern<T> AddLanguageCondition<T>(this Pattern<T> pattern, Func<System.String, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.Language, m); });
        return pattern;
    }
    public static Pattern<T> AddSyntaxTreeCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTree, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.SyntaxTree, m); });
        return pattern;
    }
    public static Pattern<T> AddFullSpanCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.Text.TextSpan, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.FullSpan, m); });
        return pattern;
    }
    public static Pattern<T> AddSpanCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.Text.TextSpan, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.Span, m); });
        return pattern;
    }
    public static Pattern<T> AddSpanStartCondition<T>(this Pattern<T> pattern, Func<System.Int32, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.SpanStart, m); });
        return pattern;
    }
    public static Pattern<T> AddIsMissingCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.IsMissing, m); });
        return pattern;
    }
    public static Pattern<T> AddIsStructuredTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.IsStructuredTrivia, m); });
        return pattern;
    }
    public static Pattern<T> AddHasStructuredTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.HasStructuredTrivia, m); });
        return pattern;
    }
    public static Pattern<T> AddContainsSkippedTextCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsSkippedText, m); });
        return pattern;
    }
    public static Pattern<T> AddContainsDirectivesCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsDirectives, m); });
        return pattern;
    }
    public static Pattern<T> AddContainsDiagnosticsCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsDiagnostics, m); });
        return pattern;
    }
    public static Pattern<T> AddHasLeadingTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.HasLeadingTrivia, m); });
        return pattern;
    }
    public static Pattern<T> AddHasTrailingTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.HasTrailingTrivia, m); });
        return pattern;
    }
    public static Pattern<T> AddParentCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxNode, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.Parent, m); });
        return pattern;
    }
    public static Pattern<T> AddParentTriviaCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTrivia, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ParentTrivia, m); });
        return pattern;
    }
    public static Pattern<T> AddContainsAnnotationsCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsAnnotations, m); });
        return pattern;
    }

    public static Pattern<T> AddRawKindCondition<T>(this Pattern<T> pattern, Func<System.Int32, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.RawKind); });
        return pattern;
    }
    public static Pattern<T> AddLanguageCondition<T>(this Pattern<T> pattern, Func<System.String, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.Language); });
        return pattern;
    }
    public static Pattern<T> AddSyntaxTreeCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTree, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.SyntaxTree); });
        return pattern;
    }
    public static Pattern<T> AddFullSpanCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.Text.TextSpan, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.FullSpan); });
        return pattern;
    }
    public static Pattern<T> AddSpanCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.Text.TextSpan, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.Span); });
        return pattern;
    }
    public static Pattern<T> AddSpanStartCondition<T>(this Pattern<T> pattern, Func<System.Int32, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.SpanStart); });
        return pattern;
    }
    public static Pattern<T> AddIsMissingCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.IsMissing); });
        return pattern;
    }
    public static Pattern<T> AddIsStructuredTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.IsStructuredTrivia); });
        return pattern;
    }
    public static Pattern<T> AddHasStructuredTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.HasStructuredTrivia); });
        return pattern;
    }
    public static Pattern<T> AddContainsSkippedTextCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsSkippedText); });
        return pattern;
    }
    public static Pattern<T> AddContainsDirectivesCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsDirectives); });
        return pattern;
    }
    public static Pattern<T> AddContainsDiagnosticsCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsDiagnostics); });
        return pattern;
    }
    public static Pattern<T> AddHasLeadingTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.HasLeadingTrivia); });
        return pattern;
    }
    public static Pattern<T> AddHasTrailingTriviaCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.HasTrailingTrivia); });
        return pattern;
    }
    public static Pattern<T> AddParentCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxNode, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.Parent); });
        return pattern;
    }
    public static Pattern<T> AddParentTriviaCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ParentTrivia); });
        return pattern;
    }
    public static Pattern<T> AddContainsAnnotationsCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.SyntaxNode)sn; return condition(n.ContainsAnnotations); });
        return pattern;
    }

    public static Pattern<T> AddParentPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.SyntaxNode
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CSharpSyntaxNodePatternPatternExtensions {


    public static Pattern<T> AddLanguageCondition<T>(this Pattern<T> pattern, Func<System.String, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)sn; return condition(n.Language, m); });
        return pattern;
    }

    public static Pattern<T> AddLanguageCondition<T>(this Pattern<T> pattern, Func<System.String, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)sn; return condition(n.Language); });
        return pattern;
    }

}

public static class AliasQualifiedNamePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddAliasCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax)sn; return condition(n.Alias, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddColonColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax)sn; return condition(n.ColonColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddAliasCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax)sn; return condition(n.Alias); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddColonColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax)sn; return condition(n.ColonColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax)sn; return condition(n.Name); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddAliasPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ArrayRankSpecifierPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddRankCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<System.Int32, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.Rank, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.OpenBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddSizesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.Sizes, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.CloseBracketToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddRankCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<System.Int32, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.Rank); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.OpenBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddSizesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.Sizes); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax)sn; return condition(n.CloseBracketToken); });
        return pattern;
    }

}

public static class AttributePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AttributeTargetSpecifierPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }

}

public static class CompilationUnitPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddExternsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.Externs, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddUsingsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.Usings, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddEndOfFileTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.EndOfFileToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddExternsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.Externs); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddUsingsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.Usings); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.Members); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> AddEndOfFileTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)sn; return condition(n.EndOfFileToken); });
        return pattern;
    }

}

public static class LocalDeclarationStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddIsConstCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.IsConst, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddIsConstCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.IsConst); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class DelegateDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddArityCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<System.Int32, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.Arity, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddDelegateKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.DelegateKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddReturnTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.ReturnType, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.TypeParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.ConstraintClauses, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddArityCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<System.Int32, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.Arity); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddDelegateKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.DelegateKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddReturnTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.ReturnType); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.TypeParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.ConstraintClauses); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddReturnTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddTypeParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class DirectiveTriviaPatternPatternExtensions {


    public static Pattern<T> AddDirectiveNameTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.DirectiveNameToken, m); });
        return pattern;
    }
    public static Pattern<T> AddHashTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<T> AddEndOfDirectiveTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<T> AddIsActiveCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<T> AddDirectiveNameTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.DirectiveNameToken); });
        return pattern;
    }
    public static Pattern<T> AddHashTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<T> AddEndOfDirectiveTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<T> AddIsActiveCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class ExpressionStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddAllowsAnyExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax)sn; return condition(n.AllowsAnyExpression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddAllowsAnyExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax)sn; return condition(n.AllowsAnyExpression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class GenericNamePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddIsUnboundGenericNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)sn; return condition(n.IsUnboundGenericName, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddTypeArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)sn; return condition(n.TypeArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddIsUnboundGenericNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)sn; return condition(n.IsUnboundGenericName); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddTypeArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)sn; return condition(n.TypeArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> AddTypeArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class PropertyDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddAccessorListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.AccessorList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.ExpressionBody, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Initializer, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddAccessorListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.AccessorList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.ExpressionBody); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.Initializer); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddExplicitInterfaceSpecifierPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddAccessorListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddExpressionBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> AddInitializerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AnonymousMethodExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.Block, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddAsyncKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.AsyncKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddDelegateKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.DelegateKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.Block); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddAsyncKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.AsyncKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddDelegateKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.DelegateKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax)sn; return condition(n.Body); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddBlockPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class IndexerDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddThisKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ThisKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddAccessorListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.AccessorList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ExpressionBody, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddThisKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ThisKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddAccessorListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.AccessorList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.ExpressionBody); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddExplicitInterfaceSpecifierPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddAccessorListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> AddExpressionBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class MethodDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddArityCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<System.Int32, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Arity, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddReturnTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ReturnType, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.TypeParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ConstraintClauses, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ExpressionBody, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddArityCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<System.Int32, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Arity); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddReturnTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ReturnType); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.TypeParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ConstraintClauses); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.ExpressionBody); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddReturnTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddExplicitInterfaceSpecifierPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddTypeParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> AddExpressionBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class NamespaceDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddNamespaceKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.NamespaceKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddExternsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Externs, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddUsingsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Usings, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddNamespaceKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.NamespaceKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddExternsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Externs); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddUsingsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Usings); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.Members); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class NamePatternPatternExtensions {


    public static Pattern<T> AddArityCondition<T>(this Pattern<T> pattern, Func<System.Int32, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)sn; return condition(n.Arity, m); });
        return pattern;
    }

    public static Pattern<T> AddArityCondition<T>(this Pattern<T> pattern, Func<System.Int32, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)sn; return condition(n.Arity); });
        return pattern;
    }

}

public static class ParameterListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

}

public static class ParameterPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddDefaultCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Default, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddDefaultCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)sn; return condition(n.Default); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> AddDefaultPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class QualifiedNamePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddLeftCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax)sn; return condition(n.Left, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddDotTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax)sn; return condition(n.DotToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddRightCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax)sn; return condition(n.Right, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddLeftCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax)sn; return condition(n.Left); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddDotTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax)sn; return condition(n.DotToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddRightCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax)sn; return condition(n.Right); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddLeftPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> AddRightPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SimpleNamePatternPatternExtensions {


    public static Pattern<T> AddIdentifierCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }

    public static Pattern<T> AddIdentifierCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }

}

public static class StructuredTriviaPatternPatternExtensions {


    public static Pattern<T> AddParentTriviaCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTrivia, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax)sn; return condition(n.ParentTrivia, m); });
        return pattern;
    }

    public static Pattern<T> AddParentTriviaCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax)sn; return condition(n.ParentTrivia); });
        return pattern;
    }

}

public static class TypeDeclarationPatternPatternExtensions {


    public static Pattern<T> AddArityCondition<T>(this Pattern<T> pattern, Func<System.Int32, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.Arity, m); });
        return pattern;
    }
    public static Pattern<T> AddKeywordCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<T> AddTypeParameterListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.TypeParameterList, m); });
        return pattern;
    }
    public static Pattern<T> AddConstraintClausesCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.ConstraintClauses, m); });
        return pattern;
    }
    public static Pattern<T> AddMembersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }

    public static Pattern<T> AddArityCondition<T>(this Pattern<T> pattern, Func<System.Int32, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.Arity); });
        return pattern;
    }
    public static Pattern<T> AddKeywordCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<T> AddTypeParameterListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.TypeParameterList); });
        return pattern;
    }
    public static Pattern<T> AddConstraintClausesCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.ConstraintClauses); });
        return pattern;
    }
    public static Pattern<T> AddMembersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax)sn; return condition(n.Members); });
        return pattern;
    }

    public static Pattern<T> AddTypeParameterListPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class TypePatternPatternExtensions {


    public static Pattern<T> AddIsVarCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax)sn; return condition(n.IsVar, m); });
        return pattern;
    }

    public static Pattern<T> AddIsVarCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax)sn; return condition(n.IsVar); });
        return pattern;
    }

}

public static class IdentifierNamePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }

}

public static class TypeArgumentListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax)sn; return condition(n.LessThanToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax)sn; return condition(n.Arguments, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax)sn; return condition(n.GreaterThanToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax)sn; return condition(n.LessThanToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax)sn; return condition(n.Arguments); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax)sn; return condition(n.GreaterThanToken); });
        return pattern;
    }

}

public static class PredefinedTypePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PredefinedTypeSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }

}

public static class ArrayTypePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> AddElementTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax)sn; return condition(n.ElementType, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> AddRankSpecifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax)sn; return condition(n.RankSpecifiers, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> AddElementTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax)sn; return condition(n.ElementType); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> AddRankSpecifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax)sn; return condition(n.RankSpecifiers); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> AddElementTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class PointerTypePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> AddElementTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax)sn; return condition(n.ElementType, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> AddAsteriskTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax)sn; return condition(n.AsteriskToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> AddElementTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax)sn; return condition(n.ElementType); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> AddAsteriskTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax)sn; return condition(n.AsteriskToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> AddElementTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class NullableTypePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> AddElementTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax)sn; return condition(n.ElementType, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> AddQuestionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax)sn; return condition(n.QuestionToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> AddElementTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax)sn; return condition(n.ElementType); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> AddQuestionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax)sn; return condition(n.QuestionToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> AddElementTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class OmittedTypeArgumentPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax> AddOmittedTypeArgumentTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax)sn; return condition(n.OmittedTypeArgumentToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax> AddOmittedTypeArgumentTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OmittedTypeArgumentSyntax)sn; return condition(n.OmittedTypeArgumentToken); });
        return pattern;
    }

}

public static class ExpressionPatternPatternExtensions {




}

public static class ParenthesizedExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class PrefixUnaryExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> AddOperandCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax)sn; return condition(n.Operand, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> AddOperandCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax)sn; return condition(n.Operand); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> AddOperandPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AwaitExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> AddAwaitKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax)sn; return condition(n.AwaitKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> AddAwaitKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax)sn; return condition(n.AwaitKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class PostfixUnaryExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> AddOperandCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax)sn; return condition(n.Operand, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> AddOperandCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax)sn; return condition(n.Operand); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> AddOperandPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class MemberAccessExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax)sn; return condition(n.Name); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ConditionalAccessExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddWhenNotNullCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax)sn; return condition(n.WhenNotNull, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddWhenNotNullCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax)sn; return condition(n.WhenNotNull); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> AddWhenNotNullPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class MemberBindingExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax)sn; return condition(n.Name); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ElementBindingExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementBindingExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ImplicitElementAccessPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitElementAccessSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BinaryExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddLeftCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax)sn; return condition(n.Left, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddRightCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax)sn; return condition(n.Right, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddLeftCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax)sn; return condition(n.Left); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddRightCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax)sn; return condition(n.Right); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddLeftPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> AddRightPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AssignmentExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddLeftCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax)sn; return condition(n.Left, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddRightCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax)sn; return condition(n.Right, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddLeftCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax)sn; return condition(n.Left); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddRightCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax)sn; return condition(n.Right); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddLeftPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> AddRightPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ConditionalExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddQuestionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.QuestionToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddWhenTrueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.WhenTrue, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddWhenFalseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.WhenFalse, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddQuestionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.QuestionToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddWhenTrueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.WhenTrue); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddWhenFalseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax)sn; return condition(n.WhenFalse); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddWhenTruePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> AddWhenFalsePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class InstanceExpressionPatternPatternExtensions {




}

public static class ThisExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax> AddTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax)sn; return condition(n.Token, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax> AddTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax)sn; return condition(n.Token); });
        return pattern;
    }

}

public static class BaseExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax> AddTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax)sn; return condition(n.Token, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax> AddTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseExpressionSyntax)sn; return condition(n.Token); });
        return pattern;
    }

}

public static class LiteralExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax> AddTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax)sn; return condition(n.Token, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax> AddTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax)sn; return condition(n.Token); });
        return pattern;
    }

}

public static class MakeRefExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.MakeRefExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class RefTypeExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class RefValueExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddCommaCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Comma, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddCommaCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Comma); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RefValueExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CheckedExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class DefaultExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class TypeOfExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SizeOfExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class InvocationExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ElementAccessExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElementAccessExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BaseArgumentListPatternPatternExtensions {


    public static Pattern<T> AddArgumentsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax)sn; return condition(n.Arguments, m); });
        return pattern;
    }

    public static Pattern<T> AddArgumentsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax)sn; return condition(n.Arguments); });
        return pattern;
    }

}

public static class ArgumentListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax)sn; return condition(n.Arguments, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax)sn; return condition(n.Arguments); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

}

public static class BracketedArgumentListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax)sn; return condition(n.OpenBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax)sn; return condition(n.Arguments, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax)sn; return condition(n.CloseBracketToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax)sn; return condition(n.OpenBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax)sn; return condition(n.Arguments); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax)sn; return condition(n.CloseBracketToken); });
        return pattern;
    }

}

public static class ArgumentPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddNameColonCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax)sn; return condition(n.NameColon, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddRefOrOutKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax)sn; return condition(n.RefOrOutKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddNameColonCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax)sn; return condition(n.NameColon); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddRefOrOutKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax)sn; return condition(n.RefOrOutKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddNameColonPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class NameColonPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CastExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CastExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AnonymousFunctionExpressionPatternPatternExtensions {


    public static Pattern<T> AddAsyncKeywordCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax)sn; return condition(n.AsyncKeyword, m); });
        return pattern;
    }
    public static Pattern<T> AddBodyCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }

    public static Pattern<T> AddAsyncKeywordCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax)sn; return condition(n.AsyncKeyword); });
        return pattern;
    }
    public static Pattern<T> AddBodyCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax)sn; return condition(n.Body); });
        return pattern;
    }

    public static Pattern<T> AddBodyPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class LambdaExpressionPatternPatternExtensions {


    public static Pattern<T> AddArrowTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax)sn; return condition(n.ArrowToken, m); });
        return pattern;
    }

    public static Pattern<T> AddArrowTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax)sn; return condition(n.ArrowToken); });
        return pattern;
    }

}

public static class SimpleLambdaExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddAsyncKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.AsyncKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddParameterCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.Parameter, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddArrowTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.ArrowToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddAsyncKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.AsyncKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddParameterCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.Parameter); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddArrowTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.ArrowToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax)sn; return condition(n.Body); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddParameterPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ParenthesizedLambdaExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddAsyncKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.AsyncKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddArrowTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.ArrowToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddAsyncKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.AsyncKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddArrowTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.ArrowToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax)sn; return condition(n.Body); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class InitializerExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> AddExpressionsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax)sn; return condition(n.Expressions, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> AddExpressionsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax)sn; return condition(n.Expressions); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }

}

public static class ObjectCreationExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.NewKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.Initializer, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.NewKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax)sn; return condition(n.Initializer); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> AddInitializerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AnonymousObjectMemberDeclaratorPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> AddNameEqualsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax)sn; return condition(n.NameEquals, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> AddNameEqualsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax)sn; return condition(n.NameEquals); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> AddNameEqualsPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AnonymousObjectCreationExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.NewKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddInitializersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.Initializers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.NewKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddInitializersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.Initializers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }

}

public static class ArrayCreationExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax)sn; return condition(n.NewKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax)sn; return condition(n.Initializer, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax)sn; return condition(n.NewKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax)sn; return condition(n.Initializer); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> AddInitializerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ImplicitArrayCreationExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.NewKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.OpenBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddCommasCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.Commas, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.CloseBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.Initializer, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.NewKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.OpenBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddCommasCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.Commas); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.CloseBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax)sn; return condition(n.Initializer); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> AddInitializerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ImplicitArrayCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class StackAllocArrayCreationExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> AddStackAllocKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax)sn; return condition(n.StackAllocKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> AddStackAllocKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax)sn; return condition(n.StackAllocKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class QueryClausePatternPatternExtensions {




}

public static class SelectOrGroupClausePatternPatternExtensions {




}

public static class QueryExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> AddFromClauseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax)sn; return condition(n.FromClause, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> AddFromClauseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax)sn; return condition(n.FromClause); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax)sn; return condition(n.Body); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> AddFromClausePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class QueryBodyPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax)sn; return condition(n.Clauses, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddSelectOrGroupCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax)sn; return condition(n.SelectOrGroup, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddContinuationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax)sn; return condition(n.Continuation, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax)sn; return condition(n.Clauses); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddSelectOrGroupCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax)sn; return condition(n.SelectOrGroup); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddContinuationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax)sn; return condition(n.Continuation); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddSelectOrGroupPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> AddContinuationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class FromClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddFromKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.FromKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddInKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.InKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddFromKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.FromKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddInKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.InKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class LetClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddLetKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.LetKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddLetKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.LetKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class JoinClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddJoinKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.JoinKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddInKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.InKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddInExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.InExpression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddOnKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.OnKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddLeftExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.LeftExpression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddEqualsKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.EqualsKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddRightExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.RightExpression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddIntoCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.Into, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddJoinKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.JoinKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddInKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.InKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddInExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.InExpression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddOnKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.OnKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddLeftExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.LeftExpression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddEqualsKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.EqualsKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddRightExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.RightExpression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddIntoCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)sn; return condition(n.Into); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddInExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddLeftExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddRightExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> AddIntoPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class JoinIntoClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> AddIntoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax)sn; return condition(n.IntoKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> AddIntoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax)sn; return condition(n.IntoKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }

}

public static class WhereClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> AddWhereKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax)sn; return condition(n.WhereKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> AddWhereKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax)sn; return condition(n.WhereKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax)sn; return condition(n.Condition); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class OrderByClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> AddOrderByKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax)sn; return condition(n.OrderByKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> AddOrderingsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax)sn; return condition(n.Orderings, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> AddOrderByKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax)sn; return condition(n.OrderByKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> AddOrderingsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax)sn; return condition(n.Orderings); });
        return pattern;
    }

}

public static class OrderingPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> AddAscendingOrDescendingKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax)sn; return condition(n.AscendingOrDescendingKeyword, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> AddAscendingOrDescendingKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax)sn; return condition(n.AscendingOrDescendingKeyword); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SelectClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> AddSelectKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax)sn; return condition(n.SelectKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> AddSelectKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax)sn; return condition(n.SelectKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class GroupClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddGroupKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.GroupKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddGroupExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.GroupExpression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddByKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.ByKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddByExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.ByExpression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddGroupKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.GroupKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddGroupExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.GroupExpression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddByKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.ByKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddByExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax)sn; return condition(n.ByExpression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddGroupExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> AddByExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class QueryContinuationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddIntoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax)sn; return condition(n.IntoKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddIntoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax)sn; return condition(n.IntoKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax)sn; return condition(n.Body); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class OmittedArraySizeExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax> AddOmittedArraySizeExpressionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax)sn; return condition(n.OmittedArraySizeExpressionToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax> AddOmittedArraySizeExpressionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OmittedArraySizeExpressionSyntax)sn; return condition(n.OmittedArraySizeExpressionToken); });
        return pattern;
    }

}

public static class InterpolatedStringExpressionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> AddStringStartTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax)sn; return condition(n.StringStartToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> AddContentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax)sn; return condition(n.Contents, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> AddStringEndTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax)sn; return condition(n.StringEndToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> AddStringStartTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax)sn; return condition(n.StringStartToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> AddContentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax)sn; return condition(n.Contents); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> AddStringEndTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax)sn; return condition(n.StringEndToken); });
        return pattern;
    }

}

public static class InterpolatedStringContentPatternPatternExtensions {




}

public static class InterpolatedStringTextPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax> AddTextTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax)sn; return condition(n.TextToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax> AddTextTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringTextSyntax)sn; return condition(n.TextToken); });
        return pattern;
    }

}

public static class InterpolationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddAlignmentClauseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.AlignmentClause, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddFormatClauseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.FormatClause, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddAlignmentClauseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.AlignmentClause); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddFormatClauseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.FormatClause); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddAlignmentClausePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> AddFormatClausePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class InterpolationAlignmentClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> AddCommaTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax)sn; return condition(n.CommaToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> AddValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax)sn; return condition(n.Value, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> AddCommaTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax)sn; return condition(n.CommaToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> AddValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax)sn; return condition(n.Value); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> AddValuePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class InterpolationFormatClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> AddFormatStringTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax)sn; return condition(n.FormatStringToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> AddFormatStringTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax)sn; return condition(n.FormatStringToken); });
        return pattern;
    }

}

public static class GlobalStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class StatementPatternPatternExtensions {




}

public static class BlockPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> AddStatementsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)sn; return condition(n.Statements, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> AddStatementsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)sn; return condition(n.Statements); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }

}

public static class VariableDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> AddVariablesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax)sn; return condition(n.Variables, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> AddVariablesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax)sn; return condition(n.Variables); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class VariableDeclaratorPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)sn; return condition(n.Initializer, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax)sn; return condition(n.Initializer); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> AddInitializerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class EqualsValueClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> AddValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)sn; return condition(n.Value, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> AddValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)sn; return condition(n.Value); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> AddValuePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class EmptyStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

}

public static class LabeledStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class GotoStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddGotoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.GotoKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddCaseOrDefaultKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.CaseOrDefaultKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddGotoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.GotoKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddCaseOrDefaultKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.CaseOrDefaultKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BreakStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> AddBreakKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax)sn; return condition(n.BreakKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> AddBreakKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax)sn; return condition(n.BreakKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

}

public static class ContinueStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> AddContinueKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax)sn; return condition(n.ContinueKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> AddContinueKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax)sn; return condition(n.ContinueKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

}

public static class ReturnStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddReturnKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax)sn; return condition(n.ReturnKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddReturnKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax)sn; return condition(n.ReturnKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ThrowStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddThrowKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax)sn; return condition(n.ThrowKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddThrowKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax)sn; return condition(n.ThrowKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class YieldStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddYieldKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.YieldKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddReturnOrBreakKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.ReturnOrBreakKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddYieldKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.YieldKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddReturnOrBreakKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.ReturnOrBreakKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class WhileStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddWhileKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.WhileKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddWhileKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.WhileKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class DoStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddDoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.DoKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddWhileKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.WhileKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddDoKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.DoKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddWhileKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.WhileKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ForStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddForKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.ForKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddInitializersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Initializers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddFirstSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.FirstSemicolonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddSecondSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.SecondSemicolonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddIncrementorsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Incrementors, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddForKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.ForKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddInitializersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Initializers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddFirstSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.FirstSemicolonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddSecondSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.SecondSemicolonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddIncrementorsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Incrementors); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ForEachStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddForEachKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.ForEachKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddInKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.InKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddForEachKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.ForEachKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddInKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.InKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class UsingStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddUsingKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.UsingKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddUsingKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.UsingKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class FixedStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddFixedKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.FixedKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddFixedKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.FixedKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CheckedStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax)sn; return condition(n.Block, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax)sn; return condition(n.Block); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> AddBlockPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class UnsafeStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> AddUnsafeKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax)sn; return condition(n.UnsafeKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax)sn; return condition(n.Block, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> AddUnsafeKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax)sn; return condition(n.UnsafeKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax)sn; return condition(n.Block); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> AddBlockPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class LockStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddLockKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.LockKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddLockKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.LockKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class IfStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddIfKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.IfKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddElseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.Else, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddIfKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.IfKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.Statement); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddElseCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax)sn; return condition(n.Else); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> AddElsePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ElseClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> AddElseKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax)sn; return condition(n.ElseKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax)sn; return condition(n.Statement, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> AddElseKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax)sn; return condition(n.ElseKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> AddStatementCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax)sn; return condition(n.Statement); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> AddStatementPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SwitchStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddSwitchKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.SwitchKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddSectionsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.Sections, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddSwitchKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.SwitchKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.Expression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddSectionsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.Sections); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SwitchSectionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> AddLabelsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax)sn; return condition(n.Labels, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> AddStatementsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax)sn; return condition(n.Statements, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> AddLabelsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax)sn; return condition(n.Labels); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> AddStatementsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax)sn; return condition(n.Statements); });
        return pattern;
    }

}

public static class SwitchLabelPatternPatternExtensions {


    public static Pattern<T> AddKeywordCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<T> AddColonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }

    public static Pattern<T> AddKeywordCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<T> AddColonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }

}

public static class CaseSwitchLabelPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax)sn; return condition(n.Value, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax)sn; return condition(n.Value); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> AddValuePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class DefaultSwitchLabelPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }

}

public static class TryStatementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddTryKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.TryKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.Block, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddCatchesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.Catches, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddFinallyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.Finally, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddTryKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.TryKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.Block); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddCatchesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.Catches); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddFinallyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax)sn; return condition(n.Finally); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddBlockPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> AddFinallyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CatchClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddCatchKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.CatchKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddFilterCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.Filter, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.Block, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddCatchKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.CatchKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddFilterCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.Filter); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)sn; return condition(n.Block); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddFilterPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> AddBlockPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CatchDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class CatchFilterClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddWhenKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.WhenKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddFilterExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.FilterExpression, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddWhenKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.WhenKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddFilterExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.FilterExpression); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> AddFilterExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class FinallyClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> AddFinallyKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax)sn; return condition(n.FinallyKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax)sn; return condition(n.Block, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> AddFinallyKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax)sn; return condition(n.FinallyKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> AddBlockCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax)sn; return condition(n.Block); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> AddBlockPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ExternAliasDirectivePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddExternKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.ExternKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddAliasKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.AliasKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddExternKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.ExternKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddAliasKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.AliasKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

}

public static class UsingDirectivePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddUsingKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.UsingKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddStaticKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.StaticKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddAliasCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.Alias, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddUsingKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.UsingKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddStaticKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.StaticKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddAliasCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.Alias); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddAliasPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class MemberDeclarationPatternPatternExtensions {




}

public static class AttributeListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.OpenBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddTargetCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.Target, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddAttributesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.Attributes, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.CloseBracketToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.OpenBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddTargetCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeTargetSpecifierSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.Target); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddAttributesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.Attributes); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax)sn; return condition(n.CloseBracketToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> AddTargetPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AttributeArgumentListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax)sn; return condition(n.Arguments, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> AddArgumentsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax)sn; return condition(n.Arguments); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

}

public static class AttributeArgumentPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddNameEqualsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax)sn; return condition(n.NameEquals, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddNameColonCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax)sn; return condition(n.NameColon, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddNameEqualsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax)sn; return condition(n.NameEquals); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddNameColonCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax)sn; return condition(n.NameColon); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddNameEqualsPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddNameColonPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class NameEqualsPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class TypeParameterListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax)sn; return condition(n.LessThanToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax)sn; return condition(n.GreaterThanToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax)sn; return condition(n.LessThanToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax)sn; return condition(n.GreaterThanToken); });
        return pattern;
    }

}

public static class TypeParameterPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> AddVarianceKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax)sn; return condition(n.VarianceKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> AddVarianceKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax)sn; return condition(n.VarianceKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }

}

public static class BaseTypeDeclarationPatternPatternExtensions {


    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<T> AddIdentifierCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<T> AddBaseListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.BaseList, m); });
        return pattern;
    }
    public static Pattern<T> AddOpenBraceTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<T> AddCloseBraceTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }
    public static Pattern<T> AddSemicolonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<T> AddIdentifierCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<T> AddBaseListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.BaseList); });
        return pattern;
    }
    public static Pattern<T> AddOpenBraceTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<T> AddCloseBraceTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }
    public static Pattern<T> AddSemicolonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<T> AddBaseListPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ClassDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.TypeParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.BaseList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.ConstraintClauses, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.TypeParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.BaseList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.ConstraintClauses); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.Members); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddTypeParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> AddBaseListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class StructDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.TypeParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.BaseList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.ConstraintClauses, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.TypeParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.BaseList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.ConstraintClauses); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.Members); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddTypeParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> AddBaseListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class InterfaceDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.TypeParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.BaseList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.ConstraintClauses, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddTypeParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.TypeParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.BaseList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddConstraintClausesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.ConstraintClauses); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.Members); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddTypeParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> AddBaseListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class EnumDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddEnumKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.EnumKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.BaseList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.Members, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddEnumKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.EnumKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddBaseListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.BaseList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddMembersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.Members); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> AddBaseListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class EnumMemberDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddEqualsValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax)sn; return condition(n.EqualsValue, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddEqualsValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax)sn; return condition(n.EqualsValue); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> AddEqualsValuePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BaseListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> AddTypesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax)sn; return condition(n.Types, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> AddTypesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax)sn; return condition(n.Types); });
        return pattern;
    }

}

public static class BaseTypePatternPatternExtensions {


    public static Pattern<T> AddTypeCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<T> AddTypeCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<T> AddTypePattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SimpleBaseTypePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleBaseTypeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class TypeParameterConstraintClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddWhereKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.WhereKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddConstraintsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.Constraints, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddWhereKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.WhereKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddConstraintsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax)sn; return condition(n.Constraints); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class TypeParameterConstraintPatternPatternExtensions {




}

public static class ConstructorConstraintPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax)sn; return condition(n.NewKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> AddNewKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax)sn; return condition(n.NewKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorConstraintSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

}

public static class ClassOrStructConstraintPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax> AddClassOrStructKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax)sn; return condition(n.ClassOrStructKeyword, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax> AddClassOrStructKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax)sn; return condition(n.ClassOrStructKeyword); });
        return pattern;
    }

}

public static class TypeConstraintPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeConstraintSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BaseFieldDeclarationPatternPatternExtensions {


    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<T> AddDeclarationCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<T> AddSemicolonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<T> AddDeclarationCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<T> AddSemicolonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<T> AddDeclarationPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class FieldDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.FieldDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class EventFieldDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddEventKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.EventKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.Declaration, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddEventKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.EventKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddDeclarationCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.Declaration); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> AddDeclarationPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventFieldDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ExplicitInterfaceSpecifierPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> AddDotTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax)sn; return condition(n.DotToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> AddDotTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax)sn; return condition(n.DotToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BaseMethodDeclarationPatternPatternExtensions {


    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<T> AddParameterListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<T> AddBodyCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<T> AddSemicolonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<T> AddParameterListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<T> AddBodyCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<T> AddSemicolonTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<T> AddParameterListPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<T> AddBodyPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class OperatorDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddReturnTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.ReturnType, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.OperatorKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.ExpressionBody, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddReturnTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.ReturnType); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.OperatorKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.ExpressionBody); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddReturnTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> AddExpressionBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ConversionOperatorDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddImplicitOrExplicitKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.ImplicitOrExplicitKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.OperatorKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.ExpressionBody, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddImplicitOrExplicitKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.ImplicitOrExplicitKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.OperatorKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddExpressionBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.ExpressionBody); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> AddExpressionBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ConstructorDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Initializer, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddInitializerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Initializer); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddInitializerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ConstructorInitializerPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddThisOrBaseKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)sn; return condition(n.ThisOrBaseKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)sn; return condition(n.ArgumentList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddThisOrBaseKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)sn; return condition(n.ThisOrBaseKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddArgumentListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax)sn; return condition(n.ArgumentList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> AddArgumentListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class DestructorDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddTildeTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.TildeToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.ParameterList, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddTildeTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.TildeToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddParameterListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.ParameterList); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddParameterListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BasePropertyDeclarationPatternPatternExtensions {


    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<T> AddTypeCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<T> AddExplicitInterfaceSpecifierCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier, m); });
        return pattern;
    }
    public static Pattern<T> AddAccessorListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.AccessorList, m); });
        return pattern;
    }

    public static Pattern<T> AddAttributeListsCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<T> AddModifiersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<T> AddTypeCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<T> AddExplicitInterfaceSpecifierCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier); });
        return pattern;
    }
    public static Pattern<T> AddAccessorListCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax)sn; return condition(n.AccessorList); });
        return pattern;
    }

    public static Pattern<T> AddTypePattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<T> AddExplicitInterfaceSpecifierPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<T> AddAccessorListPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ArrowExpressionClausePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> AddArrowTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax)sn; return condition(n.ArrowToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax)sn; return condition(n.Expression, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> AddArrowTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax)sn; return condition(n.ArrowToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> AddExpressionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax)sn; return condition(n.Expression); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> AddExpressionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class EventDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddEventKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.EventKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddAccessorListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.AccessorList, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddEventKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.EventKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddExplicitInterfaceSpecifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.ExplicitInterfaceSpecifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddAccessorListCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax)sn; return condition(n.AccessorList); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddExplicitInterfaceSpecifierPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> AddAccessorListPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class AccessorListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax)sn; return condition(n.OpenBraceToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> AddAccessorsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax)sn; return condition(n.Accessors, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax)sn; return condition(n.CloseBraceToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> AddOpenBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax)sn; return condition(n.OpenBraceToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> AddAccessorsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax)sn; return condition(n.Accessors); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> AddCloseBraceTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax)sn; return condition(n.CloseBraceToken); });
        return pattern;
    }

}

public static class AccessorDeclarationPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.Keyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.Body, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.SemicolonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.Keyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddBodyCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.Body); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddSemicolonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)sn; return condition(n.SemicolonToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> AddBodyPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BaseParameterListPatternPatternExtensions {


    public static Pattern<T> AddParametersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }

    public static Pattern<T> AddParametersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }

}

public static class BracketedParameterListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax)sn; return condition(n.OpenBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax)sn; return condition(n.CloseBracketToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax)sn; return condition(n.OpenBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax)sn; return condition(n.CloseBracketToken); });
        return pattern;
    }

}

public static class IncompleteMemberPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax)sn; return condition(n.AttributeLists, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax)sn; return condition(n.Modifiers, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddAttributeListsCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax)sn; return condition(n.AttributeLists); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddModifiersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax)sn; return condition(n.Modifiers); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IncompleteMemberSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class SkippedTokensTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax> AddTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax)sn; return condition(n.Tokens, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax> AddTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.SkippedTokensTriviaSyntax)sn; return condition(n.Tokens); });
        return pattern;
    }

}

public static class DocumentationCommentTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> AddContentCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax)sn; return condition(n.Content, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> AddEndOfCommentCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax)sn; return condition(n.EndOfComment, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> AddContentCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax)sn; return condition(n.Content); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> AddEndOfCommentCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax)sn; return condition(n.EndOfComment); });
        return pattern;
    }

}

public static class CrefPatternPatternExtensions {




}

public static class TypeCrefPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class QualifiedCrefPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddContainerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)sn; return condition(n.Container, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddDotTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)sn; return condition(n.DotToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddMemberCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)sn; return condition(n.Member, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddContainerCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)sn; return condition(n.Container); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddDotTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)sn; return condition(n.DotToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddMemberCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax)sn; return condition(n.Member); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddContainerPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> AddMemberPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class MemberCrefPatternPatternExtensions {




}

public static class NameMemberCrefPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> AddParametersPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class IndexerMemberCrefPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> AddThisKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax)sn; return condition(n.ThisKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> AddThisKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax)sn; return condition(n.ThisKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> AddParametersPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IndexerMemberCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class OperatorMemberCrefPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)sn; return condition(n.OperatorKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)sn; return condition(n.OperatorToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)sn; return condition(n.OperatorKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddOperatorTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)sn; return condition(n.OperatorToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> AddParametersPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.OperatorMemberCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ConversionOperatorMemberCrefPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddImplicitOrExplicitKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.ImplicitOrExplicitKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.OperatorKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddImplicitOrExplicitKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.ImplicitOrExplicitKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddOperatorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.OperatorKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.Type); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> AddParametersPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorMemberCrefSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class BaseCrefParameterListPatternPatternExtensions {


    public static Pattern<T> AddParametersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }

    public static Pattern<T> AddParametersCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BaseCrefParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }

}

public static class CrefParameterListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax)sn; return condition(n.OpenParenToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax)sn; return condition(n.CloseParenToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> AddOpenParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax)sn; return condition(n.OpenParenToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> AddCloseParenTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterListSyntax)sn; return condition(n.CloseParenToken); });
        return pattern;
    }

}

public static class CrefBracketedParameterListPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax)sn; return condition(n.OpenBracketToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax)sn; return condition(n.Parameters, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax)sn; return condition(n.CloseBracketToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> AddOpenBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax)sn; return condition(n.OpenBracketToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> AddParametersCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax)sn; return condition(n.Parameters); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> AddCloseBracketTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefBracketedParameterListSyntax)sn; return condition(n.CloseBracketToken); });
        return pattern;
    }

}

public static class CrefParameterPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> AddRefOrOutKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax)sn; return condition(n.RefOrOutKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax)sn; return condition(n.Type, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> AddRefOrOutKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax)sn; return condition(n.RefOrOutKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> AddTypeCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax)sn; return condition(n.Type); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> AddTypePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.CrefParameterSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlNodePatternPatternExtensions {




}

public static class XmlElementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddStartTagCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax)sn; return condition(n.StartTag, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddContentCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax)sn; return condition(n.Content, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddEndTagCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax)sn; return condition(n.EndTag, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddStartTagCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax)sn; return condition(n.StartTag); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddContentCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax)sn; return condition(n.Content); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddEndTagCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax)sn; return condition(n.EndTag); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddStartTagPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> AddEndTagPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlElementStartTagPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.LessThanToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddAttributesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.Attributes, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.GreaterThanToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.LessThanToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddAttributesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.Attributes); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax)sn; return condition(n.GreaterThanToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlElementEndTagPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddLessThanSlashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax)sn; return condition(n.LessThanSlashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax)sn; return condition(n.GreaterThanToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddLessThanSlashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax)sn; return condition(n.LessThanSlashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax)sn; return condition(n.GreaterThanToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlEmptyElementPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.LessThanToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddAttributesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.Attributes, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddSlashGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.SlashGreaterThanToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddLessThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.LessThanToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddAttributesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.Attributes); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddSlashGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax)sn; return condition(n.SlashGreaterThanToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlNamePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> AddPrefixCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax)sn; return condition(n.Prefix, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> AddLocalNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax)sn; return condition(n.LocalName, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> AddPrefixCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax)sn; return condition(n.Prefix); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> AddLocalNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax)sn; return condition(n.LocalName); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> AddPrefixPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlPrefixPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> AddPrefixCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax)sn; return condition(n.Prefix, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax)sn; return condition(n.ColonToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> AddPrefixCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax)sn; return condition(n.Prefix); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> AddColonTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax)sn; return condition(n.ColonToken); });
        return pattern;
    }

}

public static class XmlAttributePatternPatternExtensions {


    public static Pattern<T> AddNameCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<T> AddEqualsTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }
    public static Pattern<T> AddStartQuoteTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.StartQuoteToken, m); });
        return pattern;
    }
    public static Pattern<T> AddEndQuoteTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.EndQuoteToken, m); });
        return pattern;
    }

    public static Pattern<T> AddNameCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<T> AddEqualsTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }
    public static Pattern<T> AddStartQuoteTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.StartQuoteToken); });
        return pattern;
    }
    public static Pattern<T> AddEndQuoteTokenCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax)sn; return condition(n.EndQuoteToken); });
        return pattern;
    }

    public static Pattern<T> AddNamePattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlTextAttributePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddStartQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.StartQuoteToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.TextTokens, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddEndQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.EndQuoteToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddStartQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.StartQuoteToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.TextTokens); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddEndQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax)sn; return condition(n.EndQuoteToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlCrefAttributePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddStartQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.StartQuoteToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddCrefCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.Cref, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddEndQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.EndQuoteToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddStartQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.StartQuoteToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddCrefCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.Cref); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddEndQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax)sn; return condition(n.EndQuoteToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> AddCrefPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlNameAttributePatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.EqualsToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddStartQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.StartQuoteToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddEndQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.EndQuoteToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddEqualsTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.EqualsToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddStartQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.StartQuoteToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddEndQuoteTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax)sn; return condition(n.EndQuoteToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> AddIdentifierPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlTextPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax)sn; return condition(n.TextTokens, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax)sn; return condition(n.TextTokens); });
        return pattern;
    }

}

public static class XmlCDataSectionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> AddStartCDataTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax)sn; return condition(n.StartCDataToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax)sn; return condition(n.TextTokens, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> AddEndCDataTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax)sn; return condition(n.EndCDataToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> AddStartCDataTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax)sn; return condition(n.StartCDataToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax)sn; return condition(n.TextTokens); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> AddEndCDataTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCDataSectionSyntax)sn; return condition(n.EndCDataToken); });
        return pattern;
    }

}

public static class XmlProcessingInstructionPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddStartProcessingInstructionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.StartProcessingInstructionToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.TextTokens, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddEndProcessingInstructionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.EndProcessingInstructionToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddStartProcessingInstructionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.StartProcessingInstructionToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.TextTokens); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddEndProcessingInstructionTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax)sn; return condition(n.EndProcessingInstructionToken); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> AddNamePattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlProcessingInstructionSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class XmlCommentPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> AddLessThanExclamationMinusMinusTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax)sn; return condition(n.LessThanExclamationMinusMinusToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax)sn; return condition(n.TextTokens, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> AddMinusMinusGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax)sn; return condition(n.MinusMinusGreaterThanToken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> AddLessThanExclamationMinusMinusTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax)sn; return condition(n.LessThanExclamationMinusMinusToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> AddTextTokensCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxTokenList, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax)sn; return condition(n.TextTokens); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> AddMinusMinusGreaterThanTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.XmlCommentSyntax)sn; return condition(n.MinusMinusGreaterThanToken); });
        return pattern;
    }

}

public static class BranchingDirectiveTriviaPatternPatternExtensions {


    public static Pattern<T> AddBranchTakenCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BranchingDirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BranchingDirectiveTriviaSyntax)sn; return condition(n.BranchTaken, m); });
        return pattern;
    }

    public static Pattern<T> AddBranchTakenCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.BranchingDirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BranchingDirectiveTriviaSyntax)sn; return condition(n.BranchTaken); });
        return pattern;
    }

}

public static class ConditionalDirectiveTriviaPatternPatternExtensions {


    public static Pattern<T> AddConditionCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<T> AddConditionValueCondition<T>(this Pattern<T> pattern, Func<System.Boolean, MatchContext, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax)sn; return condition(n.ConditionValue, m); });
        return pattern;
    }

    public static Pattern<T> AddConditionCondition<T>(this Pattern<T> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<T> AddConditionValueCondition<T>(this Pattern<T> pattern, Func<System.Boolean, bool> condition)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax)sn; return condition(n.ConditionValue); });
        return pattern;
    }

    public static Pattern<T> AddConditionPattern<T>(this Pattern<T> pattern, Pattern propertyPattern)
        where T: Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalDirectiveTriviaSyntax
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class IfDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddIfKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.IfKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddBranchTakenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.BranchTaken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddConditionValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.ConditionValue, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddIfKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.IfKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddBranchTakenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.BranchTaken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddConditionValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax)sn; return condition(n.ConditionValue); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.IfDirectiveTriviaSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ElifDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddElifKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.ElifKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.Condition, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddBranchTakenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.BranchTaken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddConditionValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.ConditionValue, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddElifKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.ElifKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddConditionCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.Condition); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddBranchTakenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.BranchTaken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddConditionValueCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax)sn; return condition(n.ConditionValue); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> AddConditionPattern(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElifDirectiveTriviaSyntax> pattern, Pattern propertyPattern)
    {
        if(propertyPattern != null) pattern.AddCondition((SyntaxNode node, MatchContext match) => propertyPattern.DoMatch(node, match));
        return pattern;
    }
}

public static class ElseDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddElseKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.ElseKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddBranchTakenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.BranchTaken, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddElseKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.ElseKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> AddBranchTakenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ElseDirectiveTriviaSyntax)sn; return condition(n.BranchTaken); });
        return pattern;
    }

}

public static class EndIfDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddEndIfKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.EndIfKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddEndIfKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.EndIfKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndIfDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class RegionDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddRegionKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.RegionKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddRegionKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.RegionKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.RegionDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class EndRegionDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddEndRegionKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.EndRegionKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddEndRegionKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.EndRegionKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.EndRegionDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class ErrorDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddErrorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.ErrorKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddErrorKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.ErrorKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ErrorDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class WarningDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddWarningKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.WarningKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddWarningKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.WarningKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.WarningDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class BadDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.Identifier, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddIdentifierCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.Identifier); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.BadDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class DefineDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddDefineKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.DefineKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddDefineKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.DefineKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.DefineDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class UndefDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddUndefKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.UndefKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.Name, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddUndefKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.UndefKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddNameCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.Name); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.UndefDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class LineDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddLineKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.LineKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddLineCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.Line, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.File, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddLineKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.LineKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddLineCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.Line); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.File); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class PragmaWarningDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddPragmaKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.PragmaKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddWarningKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.WarningKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddDisableOrRestoreKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.DisableOrRestoreKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddErrorCodesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.ErrorCodes, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddPragmaKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.PragmaKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddWarningKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.WarningKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddDisableOrRestoreKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.DisableOrRestoreKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddErrorCodesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.ErrorCodes); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class PragmaChecksumDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddPragmaKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.PragmaKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddChecksumKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.ChecksumKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.File, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddGuidCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.Guid, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddBytesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.Bytes, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddPragmaKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.PragmaKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddChecksumKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.ChecksumKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.File); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddGuidCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.Guid); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddBytesCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.Bytes); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.PragmaChecksumDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class ReferenceDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddReferenceKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.ReferenceKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.File, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddReferenceKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.ReferenceKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.File); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ReferenceDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class LoadDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddLoadKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.LoadKeyword, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.File, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddLoadKeywordCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.LoadKeyword); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddFileCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.File); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.LoadDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

public static class ShebangDirectiveTriviaPatternPatternExtensions {


    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.HashToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddExclamationTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.ExclamationToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken, m); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<System.Boolean, MatchContext, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn, MatchContext m) => {var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.IsActive, m); });
        return pattern;
    }

    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddHashTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.HashToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddExclamationTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.ExclamationToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddEndOfDirectiveTokenCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<Microsoft.CodeAnalysis.SyntaxToken, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.EndOfDirectiveToken); });
        return pattern;
    }
    public static Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> AddIsActiveCondition(this Pattern<Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax> pattern, Func<System.Boolean, bool> condition)
    {
        pattern.AddCondition((SyntaxNode sn) => { var n = (Microsoft.CodeAnalysis.CSharp.Syntax.ShebangDirectiveTriviaSyntax)sn; return condition(n.IsActive); });
        return pattern;
    }

}

                
}

