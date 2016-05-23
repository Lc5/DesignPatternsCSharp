namespace DesignPatterns.GangOfFour.Behavioral.TemplateMethod
{
    using System;

    public abstract class DataExporter
    {
        public abstract void ExportData();

        public void ExportFormattedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData();
        }

        public void FormatData()
        {
            Console.WriteLine("Formatting data.");
        }

        public void ReadData()
        {
            Console.WriteLine("Reading data from external source.");
        }
    }
}