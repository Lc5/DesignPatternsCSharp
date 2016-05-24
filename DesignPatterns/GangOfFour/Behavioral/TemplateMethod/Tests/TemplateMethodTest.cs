namespace DesignPatterns.GangOfFour.Behavioral.TemplateMethod.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.TemplateMethod;

    using NUnit.Framework;

    [TestFixture]
    public class TemplateMethodTest
    {
        [Test]
        public void TestTemplateMethod()
        {
            var excelExporter = new ExcelExporter();
            excelExporter.ExportFormattedData();

            // Reading data from external source.

            // Formatting data.

            // Exporting data to Excel file.

            var pdfExporter = new PdfExporter();
            pdfExporter.ExportFormattedData();

            // Reading data from external source.

            // Formatting data.

            // Exporting data to PDF file.
        }
    }
}