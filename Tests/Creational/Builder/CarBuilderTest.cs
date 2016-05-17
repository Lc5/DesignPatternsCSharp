namespace DesignPatterns.Tests.Creational.Builder
{
    using DesignPatterns.Creational.Builder;

    using NUnit.Framework;

    [TestFixture]
    public class CarBuilderTest
    {
        [Test]
        public void TestBuildCar()
        {
            var carBuilder = new CarBuilder();

            var car = carBuilder
                .SetColor("Black")
                .SetEngineCapacity(2000)
                .SetName("BMW 320")
                .SetNumberOfDoors(5)
                .SetNumberOfSeats(5)
                .BuildCar();

            Assert.That(car.Color, Is.EqualTo("Black"));
            Assert.That(car.EngineCapacity, Is.EqualTo(2000));
            Assert.That(car.Name, Is.EqualTo("BMW 320"));
            Assert.That(car.NumberOfDoors, Is.EqualTo(5));
            Assert.That(car.NumberOfSeats, Is.EqualTo(5));
        }
    }
}