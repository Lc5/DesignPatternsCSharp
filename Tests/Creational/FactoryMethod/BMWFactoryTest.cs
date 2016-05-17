namespace DesignPatterns.Tests.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;
    using DesignPatterns.Creational.FactoryMethod;

    using NUnit.Framework;

    [TestFixture]
    public class BmwFactoryTest
    {
        [Test]
        public void TestBuildCar()
        {
            var carFactory = new BmwFactory();

            Assert.That(carFactory.BuildCar(), Is.InstanceOf<Bmw>());
        }
    }
}