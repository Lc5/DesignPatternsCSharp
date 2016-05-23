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
                this.carBuilder.SetColor("Blue")
                    .SetEngineCapacity(3000)
                    .SetName("Audi A8")
                    .SetNumberOfDoors(5)
                    .SetNumberOfSeats(5)
                    .BuildCar();
        }
    }
}