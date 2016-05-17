namespace DesignPatterns.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;

    public class BMWFactory : ICarFactory
    {
        public ICar BuildCar()
        {
            return new Bmw();
        }
    }
}