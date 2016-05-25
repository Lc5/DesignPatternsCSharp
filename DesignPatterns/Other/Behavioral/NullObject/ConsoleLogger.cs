namespace DesignPatterns.Other.Behavioral.NullObject
{
    using System;

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}