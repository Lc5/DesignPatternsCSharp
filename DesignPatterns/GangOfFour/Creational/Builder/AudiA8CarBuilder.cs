namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class AudiA8CarBuilder : ICarBuilder
    {
        private readonly ICar car;

        public AudiA8CarBuilder()
        {
            this.car = new Car();
        }

        public ICar BuildCar()
        {
            return this.car;
        }

        public ICarBuilder SetColor()
        {
            this.car.Color = "Blue";

            return this;
        }

        public ICarBuilder SetEngineCapacity()
        {
            this.car.EngineCapacity = 3000;

            return this;
        }

        public ICarBuilder SetName()
        {
            this.car.Name = "Audi A8";

            return this;
        }

        public ICarBuilder SetNumberOfDoors()
        {
            this.car.NumberOfDoors = 5;

            return this;
        }

        public ICarBuilder SetNumberOfSeats()
        {
            this.car.NumberOfSeats = 5;

            return this;
        }
    }
}