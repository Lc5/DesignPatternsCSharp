namespace DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    public class AudiFactory : ICarFactory
    {
        public ICar BuildCar()
        {
            return new Audi();
        }
    }
}