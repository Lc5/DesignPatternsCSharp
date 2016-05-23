namespace DesignPatterns.Tests.GangOfFour.Structural.Flyweight
{
    using DesignPatterns.GangOfFour.Structural.Flyweight;

    using NUnit.Framework;

    [TestFixture]
    public class FlyweightTest
    {
        [SetUp]
        public void SetUp()
        {
            CircleFactory.Circles.Clear();
        }

        [Test]
        public void TestGetCircleReturnsDifferentCirclesForDifferentColor()
        {
            CircleFactory.GetCircle(0, 0, 10, "Red");
            CircleFactory.GetCircle(0, 0, 10, "Blue");

            Assert.That(CircleFactory.Circles.Count, Is.EqualTo(2));
        }

        [Test]
        public void TestGetCircleReturnsDifferentCirclesForDifferentRadius()
        {
            CircleFactory.GetCircle(0, 0, 10, "Red");
            CircleFactory.GetCircle(0, 0, 11, "Red");

            Assert.That(CircleFactory.Circles.Count, Is.EqualTo(2));
        }

        [Test]
        public void TestGetCircleReturnsSameCircleForSameRadiusAndColor()
        {
            CircleFactory.GetCircle(0, 0, 10, "Red");
            CircleFactory.GetCircle(0, 0, 10, "Red");
            CircleFactory.GetCircle(10, 10, 10, "Red");
            CircleFactory.GetCircle(10, 10, 10, "Red");

            Assert.That(CircleFactory.Circles.Count, Is.EqualTo(1));
        }
    }
}