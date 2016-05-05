namespace DesignPatterns.Tests.Creational.Factory
{
    using System;

    using DesignPatterns.Creational.SimpleFactory;

    using NUnit.Framework;

    [TestFixture]
    public class SimpleFactoryTest
    {
        [TestCase(SimpleFactory.Cars.Audi, typeof(Audi))]
        [TestCase(SimpleFactory.Cars.BMW, typeof(BMW))]
        public void TestSimpleFactoryBuildsCar(SimpleFactory.Cars carName, Type carType)
        {
            var car = SimpleFactory.BuildCar(carName);

            Assert.That(car.GetType(), Is.EqualTo(carType));
        }

        [Test]
        public void TestSimpleFactoryThrowsException()
        {
            Assert.That(() => SimpleFactory.BuildCar((SimpleFactory.Cars)100), Throws.ArgumentException);
        }
    }
}
