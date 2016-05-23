namespace DesignPatterns.Tests.GangOfFour.Behavioral.Visitor
{
    using DesignPatterns.GangOfFour.Behavioral.Visitor;

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

            Assert.That(
                htmlVisitor.Output,
                Is.EqualTo("<b>This is bold text.</b>This is plain text.<a href=\"http://www.example.com\">This is hyperlink.</a>"));

            var latexVisitor = new LatexVisitor();
            document.Accept(latexVisitor);

            Assert.That(
                latexVisitor.Output,
                Is.EqualTo("\\textbf{This is bold text.}This is plain text.\\href{http://www.example.com}{This is hyperlink.}"));
        }
    }
}