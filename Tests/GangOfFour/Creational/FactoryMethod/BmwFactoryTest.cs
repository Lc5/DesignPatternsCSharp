namespace DesignPatterns.Tests.GangOfFour.Creational.FactoryMethod
{
    using DesignPatterns.GangOfFour.Creational.FactoryMethod;

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