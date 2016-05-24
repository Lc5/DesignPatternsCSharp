namespace DesignPatterns.GangOfFour.Creational.Prototype.Tests
{
    using DesignPatterns.GangOfFour.Creational.Prototype;

    using NUnit.Framework;

    [TestFixture]
    public class PrototypeTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new ConcretePrototype1(123) },
            new[] { new ConcretePrototype2(456) }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestPrototype(Prototype prototype)
        {
            var newInstance = prototype.Clone();

            Assert.That(newInstance.Id, Is.EqualTo(prototype.Id));
            Assert.That(newInstance, Is.Not.EqualTo(prototype));
        }
    }
}