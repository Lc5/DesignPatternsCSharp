namespace DesignPatterns.Tests.GangOfFour.Creational.FactoryMethod
{
    using System;

    using DesignPatterns.GangOfFour.Creational.FactoryMethod;

    using NUnit.Framework;

    [TestFixture]
    public class ICarFactoryTest
    {
        [TestCase(typeof(AudiFactory))]
        [TestCase(typeof(BmwFactory))]
        public void TestBuildCar(Type carFactoryType)
        {
            var carFactory = (ICarFactory)Activator.CreateInstance(carFactoryType);

            Assert.That(carFactory.BuildCar(), Is.InstanceOf<ICar>());
        }
    }
}