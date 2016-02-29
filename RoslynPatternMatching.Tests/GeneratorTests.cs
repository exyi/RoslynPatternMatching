using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternNodeGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynPatternMatching.Tests
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        public void FormattingGenericType()
        {
            Assert.AreEqual(typeof(List<Dictionary<object, object>>).FormatType(), "System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Object, System.Object>>");
        }

        [TestMethod]
        public void GeneratorTests_ListsNodes()
        {
            var nodes = new RoslynSyntaxNodeFinder().CrawlNodes().ToArray();
            Assert.IsTrue(nodes.Any(n => n.Type == typeof(ThisExpressionSyntax)));
        }
    }
}
