namespace DesignPatterns.Creational.Builder
{
    public interface ICarBuilder
    {
        ICar BuildCar();

        ICarBuilder SetColor(string color);

        ICarBuilder SetEngineCapacity(int engineCapacity);

        ICarBuilder SetName(string name);

        ICarBuilder SetNumberOfDoors(int numberOfDoors);

        ICarBuilder SetNumberOfSeats(int numberOfSeats);
    }
}