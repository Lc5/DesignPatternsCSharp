namespace DesignPatterns.Creational.SimpleFactory
{
    using System;

    public class BMW : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving BMW!");
        }
    }
}
