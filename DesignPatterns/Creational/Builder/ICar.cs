namespace DesignPatterns.Creational.Builder
{
    public interface ICar
    {
        string Color { get; set; }

        int EngineCapacity { get; set; }

        string Name { get; set; }

        int NumberOfDoors { get; set; }

        int NumberOfSeats { get; set; }

        void Drive();
    }
}