namespace DesignPatterns.Tests.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;
    using DesignPatterns.Creational.FactoryMethod;

    using NUnit.Framework;

    [TestFixture]
    public class AudiFactoryTest
    {
        [Test]
        public void TestBuildCar()
        {
            var carFactory = new AudiFactory();

            Assert.That(carFactory.BuildCar(), Is.InstanceOf<Audi>());
        }
    }
}