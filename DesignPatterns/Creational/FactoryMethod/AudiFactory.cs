namespace DesignPatterns.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;

    public class AudiFactory : ICarFactory
    {
        public ICar BuildCar()
        {
            return new Audi();
        }
    }
}