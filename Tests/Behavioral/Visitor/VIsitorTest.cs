namespace DesignPatterns.Tests.Behavioral.Visitor
{
    using System;

    using DesignPatterns.Behavioral.Visitor;

    using NUnit.Framework;
    
    [TestFixture]
    public class VisitorTest
    {
        [Test]
        public void TestVisitor()
        {
            var document = new Document();
            document.AddPart(new BoldText("This is bold text."));
            document.AddPart(new PlainText("This is plain text."));
            document.AddPart(new Hyperlink("This is hyperlink.", "http://www.example.com"));

            var htmlVisitor = new HtmlVisitor();
            document.Accept(htmlVisitor);

            Console.WriteLine(htmlVisitor.Output);

            var latexVisitor = new LatexVisitor();
            document.Accept(latexVisitor);

            Console.WriteLine(latexVisitor.Output);
        }
    }
}