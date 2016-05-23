namespace DesignPatterns.Tests.GangOfFour.Structural.Proxy
{
    using DesignPatterns.GangOfFour.Structural.Proxy;

    using NUnit.Framework;

    [TestFixture]
    public class CarProxyTest
    {
        [Test]
        public void TestDriveWithAdultDriver()
        {
            var carProxy = new CarProxy(new Driver(21));

            carProxy.Drive();
        }

        [Test]
        public void TestDriveWithYoungDriverThrowsInvalidArgumentException()
        {
            var carProxy = new CarProxy(new Driver(16));

            Assert.That(() => carProxy.Drive(), Throws.ArgumentException);
        }
    }
}