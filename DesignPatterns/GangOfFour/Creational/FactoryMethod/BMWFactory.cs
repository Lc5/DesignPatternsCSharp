namespace DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    public class BmwFactory : ICarFactory
    {
        public ICar BuildCar()
        {
            return new Bmw();
        }
    }
}