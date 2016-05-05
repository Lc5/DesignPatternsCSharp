namespace DesignPatterns.Creational.SimpleFactory
{
    using System;

    public class Audi : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving Audi!");
        }
    }
}
