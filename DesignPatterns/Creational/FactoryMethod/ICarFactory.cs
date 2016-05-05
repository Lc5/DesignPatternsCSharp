namespace DesignPatterns.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;

    public interface ICarFactory
    {
        ICar BuildCar();
    }
}
