namespace DesignPatterns.Creational.Builder
{
    using System;

    public class Car : ICar
    {
        public string Color { get; set; }

        public int EngineCapacity { get; set; }

        public string Name { get; set; }

        public int NumberOfDoors { get; set; }

        public int NumberOfSeats { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving common car!");
        }
    }
}