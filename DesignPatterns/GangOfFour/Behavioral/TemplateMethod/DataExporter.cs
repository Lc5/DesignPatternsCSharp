namespace DesignPatterns.GangOfFour.Behavioral.TemplateMethod
{
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
            // Format data
        }

        public void ReadData()
        {
            // Read data from external source
        }
    }
}