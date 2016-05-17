namespace DesignPatterns.Tests.Creational.SimpleFactory
{
    using System;

    using DesignPatterns.Creational.Common;
    using DesignPatterns.Creational.SimpleFactory;

    using NUnit.Framework;

    [TestFixture]
    public class CarFactoryTest
    {
        [TestCase(CarFactory.Cars.Audi, typeof(Audi))]
        [TestCase(CarFactory.Cars.BMW, typeof(Bmw))]
        public void TestSimpleFactoryBuildsCar(CarFactory.Cars carName, Type carType)
        {
            var car = CarFactory.BuildCar(carName);

            Assert.That(car.GetType(), Is.EqualTo(carType));
        }

        [Test]
        public void TestSimpleFactoryThrowsException()
        {
            Assert.That(() => CarFactory.BuildCar((CarFactory.Cars)100), Throws.ArgumentException);
        }
    }
}