namespace DesignPatterns.Tests.Behavioral.TemplateMethod
{
    using DesignPatterns.Behavioral.TemplateMethod;

    using NUnit.Framework;

    [TestFixture]
    public class TemplateMethodTest
    {
        [Test]
        public void TestTemplateMethod()
        {
            DataExporter exporter;

            exporter = new ExcelExporter();
            exporter.ExportFormattedData();

            exporter = new PdfExporter();
            exporter.ExportFormattedData();
        }
    }
}