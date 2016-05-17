namespace DesignPatterns.Tests.Structural.Composite
{
    using DesignPatterns.Structural.Composite;

    using NUnit.Framework;

    [TestFixture]
    public class FormTest
    {
        [Test]
        public void TestForm()
        {
            var form = new Form();
            form.AddElement(new InputElement());
            form.AddElement(new TextElement());

            var embeddedForm = new Form();
            embeddedForm.AddElement(new InputElement());
            embeddedForm.AddElement(new TextElement());

            form.AddElement(embeddedForm);

            var expectedOutput = "<form>\r\n" + "    <input type=\"text\" />\r\n" + "    Text element\r\n"
                                 + "    <form>\r\n" + "        <input type=\"text\" />\r\n" + "        Text element\r\n"
                                 + "    </form>\r\n" + "</form>\r\n";

            Assert.That(form.Render(), Is.EqualTo(expectedOutput));
        }
    }
}