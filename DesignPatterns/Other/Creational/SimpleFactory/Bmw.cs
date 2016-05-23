namespace DesignPatterns.Other.Creational.SimpleFactory
{
    using System;

    public class Bmw : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving BMW!");
        }
    }
}