namespace DesignPatterns.Tests.Creational.Prototype
{
    using System;

    using DesignPatterns.Creational.Prototype;

    using NUnit.Framework;
    
    [TestFixture]
    class PrototypeTest
    {
        [TestCase(typeof(ConcretePrototype1))]
        [TestCase(typeof(ConcretePrototype2))]
        public void TestPrototype(Type prototype)
        {
            var concretePrototype = (Prototype)Activator.CreateInstance(prototype, 123);
            var newInstance = concretePrototype.Clone();

            Assert.That(newInstance.Id, Is.EqualTo(concretePrototype.Id));
            Assert.That(newInstance, Is.Not.EqualTo(concretePrototype));
        }
    }
}
