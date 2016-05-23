namespace DesignPatterns.Tests.GangOfFour.Structural.Composite
{
    using DesignPatterns.GangOfFour.Structural.Composite;

    using NUnit.Framework;

    [TestFixture]
    public class CompositeTest
    {
        [Test]
        public void TestComposite()
        {
            var form = new Form();
            form.AddElement(new InputElement());
            form.AddElement(new TextElement());

            var embeddedForm = new Form();
            embeddedForm.AddElement(new InputElement());
            embeddedForm.AddElement(new TextElement());

            form.AddElement(embeddedForm);

            const string ExpectedOutput = "<form>\r\n" + 
                                          "    <input type=\"text\" />\r\n" + 
                                          "    Text element\r\n" + 
                                          "    <form>\r\n" + 
                                          "        <input type=\"text\" />\r\n" + 
                                          "        Text element\r\n" + 
                                          "    </form>\r\n" + 
                                          "</form>\r\n";

            Assert.That(form.Render(), Is.EqualTo(ExpectedOutput));
        }
    }
}