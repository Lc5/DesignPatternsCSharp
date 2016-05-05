namespace DesignPatterns.Tests.Creational.FactoryMethod
{
    using System;

    using DesignPatterns.Creational.Common;

    using DesignPatterns.Creational.FactoryMethod;

    using NUnit.Framework;
    
    [TestFixture]
    class ICarFactoryTest
    {
        [TestCase(typeof(AudiFactory))]
        [TestCase(typeof(BMWFactory))]
        public void TestBuildCar(Type carFactoryType)
        {
            var carFactory = (ICarFactory)Activator.CreateInstance(carFactoryType);

            Assert.That(carFactory.BuildCar(), Is.InstanceOf<ICar>());
        }
    }
}
