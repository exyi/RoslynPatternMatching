using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoslynPatternMatching;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynPatternMatching.Tests
{
    [TestClass]
    public class SimpleTests
    {

        [TestMethod]
        public void SimpleExpression()
        {
            var sn = SyntaxFactory.ParseExpression("x*5+x*4");
        }

        [TestMethod]
        public void ComplexFor()
        {
            var sn = SyntaxFactory.ParseStatement(@"
for(i = 0; i < array.Length; i++) {
    item = array[i];
    Console.WriteLine(item);
}
");
            #region This mess is using syntax factory
            var t = SyntaxFactory.ForStatement(
                SyntaxFactory.Block(
                    SyntaxFactory.List<StatementSyntax>(
                        new StatementSyntax[]{
                                        SyntaxFactory.ExpressionStatement(
                                            SyntaxFactory.AssignmentExpression(
                                                SyntaxKind.SimpleAssignmentExpression,
                                                SyntaxFactory.IdentifierName(
                                                    @"item"),
                                                SyntaxFactory.ElementAccessExpression(
                                                    SyntaxFactory.IdentifierName(
                                                        @"array"))
                                                .WithArgumentList(
                                                    SyntaxFactory.BracketedArgumentList(
                                                        SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                                                            SyntaxFactory.Argument(
                                                                SyntaxFactory.IdentifierName(
                                                                    @"i"))))
                                                    
                                                    ))
                                            )
                                        ,
                                        SyntaxFactory.ExpressionStatement(
                                            SyntaxFactory.InvocationExpression(
                                                SyntaxFactory.MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    SyntaxFactory.IdentifierName(
                                                        @"Console"),
                                                    SyntaxFactory.IdentifierName(
                                                        @"WriteLine"))
                                                )
                                            .WithArgumentList(
                                                SyntaxFactory.ArgumentList(
                                                    SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                                                        SyntaxFactory.Argument(
                                                            SyntaxFactory.IdentifierName(
                                                                @"item"))))
                                                
                                                ))
                                        })))
            .WithInitializers(
                SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                    SyntaxFactory.AssignmentExpression(
                        SyntaxKind.SimpleAssignmentExpression,
                        SyntaxFactory.IdentifierName(
                            @"i"),
                        SyntaxFactory.LiteralExpression(
                            SyntaxKind.NumericLiteralExpression,
                            SyntaxFactory.Literal(
                                SyntaxFactory.TriviaList(),
                                @"0",
                                0,
                                SyntaxFactory.TriviaList())))
                    ))
            
            .WithCondition(
                SyntaxFactory.BinaryExpression(
                    SyntaxKind.LessThanExpression,
                    SyntaxFactory.IdentifierName(
                        @"i"),
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName(
                            @"array"),
                        SyntaxFactory.IdentifierName(
                            @"Length"))
                    )
                )
            .WithIncrementors(
                SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                    SyntaxFactory.PostfixUnaryExpression(
                        SyntaxKind.PostIncrementExpression,
                        SyntaxFactory.IdentifierName(
                            @"i"))));
            #endregion

            var pattern = new Pattern<ForStatementSyntax>();
        }
    }
}
