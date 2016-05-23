namespace DesignPatterns.GangOfFour.Structural.Proxy
{
    using System;

    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving car.");
        }
    }
}