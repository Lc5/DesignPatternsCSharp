namespace DesignPatterns.Tests.Creational.FactoryMethod
{
    using DesignPatterns.Creational.Common;

    using DesignPatterns.Creational.FactoryMethod;

    using NUnit.Framework;

    [TestFixture]
    class BMWFactoryTest
    {
        [Test]
        public void TestBuildCar()
        {
            var carFactory = new BMWFactory();

            Assert.That(carFactory.BuildCar(), Is.InstanceOf<BMW>());
        }
    }
}
