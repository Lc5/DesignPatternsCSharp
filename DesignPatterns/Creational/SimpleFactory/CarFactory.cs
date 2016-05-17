namespace DesignPatterns.Creational.SimpleFactory
{
    using System;

    using DesignPatterns.Creational.Common;

    public class CarFactory
    {
        public enum Cars
        {
            Audi, 

            Bmw
        }

        public static ICar BuildCar(Cars carName)
        {
            switch (carName)
            {
                case Cars.Audi:
                    return new Audi();
                case Cars.Bmw:
                    return new Bmw();
                default:
                    throw new ArgumentException();
            }
        }
    }
}