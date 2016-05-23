namespace DesignPatterns.Tests.GangOfFour.Creational.FactoryMethod
{
    using DesignPatterns.GangOfFour.Creational.FactoryMethod;

    using NUnit.Framework;

    [TestFixture]
    public class FactoryMethodTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new AudiFactory() },
            new[] { new BmwFactory() }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestFactoryMethod(ICarFactory carFactory)
        {
            Assert.That(carFactory.BuildCar(), Is.InstanceOf<ICar>());
        }
    }
}