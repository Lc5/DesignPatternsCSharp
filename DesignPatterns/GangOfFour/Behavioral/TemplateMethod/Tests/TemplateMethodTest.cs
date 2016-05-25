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

            // OUTPUT: Reading data from external source.

            // OUTPUT: Formatting data.

            // OUTPUT: Exporting data to Excel file.

            var pdfExporter = new PdfExporter();
            pdfExporter.ExportFormattedData();

            // OUTPUT: Reading data from external source.

            // OUTPUT: Formatting data.

            // OUTPUT: Exporting data to PDF file.
        }
    }
}