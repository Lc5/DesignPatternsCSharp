namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public interface ICarBuilder
    {
        ICar BuildCar();

        ICarBuilder SetColor();

        ICarBuilder SetEngineCapacity();

        ICarBuilder SetName();

        ICarBuilder SetNumberOfDoors();

        ICarBuilder SetNumberOfSeats();
    }
}