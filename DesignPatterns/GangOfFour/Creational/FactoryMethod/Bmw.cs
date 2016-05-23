namespace DesignPatterns.GangOfFour.Creational.FactoryMethod
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