namespace DesignPatterns.Tests.GangOfFour.Creational.FactoryMethod
{
    using DesignPatterns.GangOfFour.Creational.FactoryMethod;

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