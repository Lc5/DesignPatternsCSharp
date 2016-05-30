namespace DesignPatterns.Other.Behavioral.NullObject
{
    public class Service
    {
        private readonly ILogger logger;

        public Service(ILogger logger)
        {
            this.logger = logger;
        }

        public void PerformOperation()
        {
            this.logger.Log("Performing operation.");
        }
    }
}