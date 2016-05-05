namespace DesignPatterns.Creational.SimpleFactory
{
    using System;

    using DesignPatterns.Creational.Common;

    public class CarFactory
    {
        public enum Cars
        {
            Audi,
            BMW
        }

        public static ICar BuildCar(Cars carName)
        {
            switch (carName)
            {
                case Cars.Audi:
                    return new Audi();
                case Cars.BMW:
                    return new BMW();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
