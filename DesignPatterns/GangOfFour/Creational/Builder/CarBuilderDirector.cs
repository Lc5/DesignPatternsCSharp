namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class CarBuilderDirector
    {
        private readonly ICarBuilder carBuilder;

        public CarBuilderDirector(ICarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public ICar BuildCar()
        {
            return
                this.carBuilder.SetColor()
                    .SetEngineCapacity()
                    .SetName()
                    .SetNumberOfDoors()
                    .SetNumberOfSeats()
                    .BuildCar();
        }
    }
}