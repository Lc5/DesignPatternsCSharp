namespace DesignPatterns.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;

    public class BmwFactory : ICarFactory
    {
        public ICar BuildCar()
        {
            return new Bmw();
        }
    }
}