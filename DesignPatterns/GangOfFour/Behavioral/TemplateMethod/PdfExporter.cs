namespace DesignPatterns.GangOfFour.Behavioral.TemplateMethod
{
    using System;

    public class PdfExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting data to PDF file.");
        }
    }
}