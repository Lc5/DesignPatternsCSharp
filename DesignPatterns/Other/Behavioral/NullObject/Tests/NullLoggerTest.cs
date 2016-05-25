namespace DesignPatterns.Other.Behavioral.NullObject.Tests
{
    using DesignPatterns.Other.Behavioral.NullObject;
    using NUnit.Framework;

    [TestFixture]
    class NullLoggerTest
    {
        [Test]
        public void TestNullLogger()
        {
            var logger = new ConsoleLogger();
            var service1 = new Service(logger);

            service1.PerformOperation();

            // OUTPUT: Performing operation.

            var nullLogger = new NullLogger();
            var service2 = new Service(nullLogger);

            service2.PerformOperation();
    }
}