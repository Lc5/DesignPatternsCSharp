namespace DesignPatterns.GangOfFour.Behavioral.TemplateMethod
{
    using System;

    public class ExcelExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting data to Excel file.");
        }
    }
}