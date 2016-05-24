namespace DesignPatterns.Tests.GangOfFour.Structural.Decorator
{
    using DesignPatterns.GangOfFour.Structural.Decorator;

    using NUnit.Framework;

    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void TestDecorator()
        {
            var decoratedWindow = 
                new VerticalScrollBarDecorator(
                    new HorizontalScrollBarDecorator(
                        new SimpleWindow()));

            Assert.That(
                decoratedWindow.Description, 
                Is.EqualTo("Simple window, including horizontal scroll bar, including vertical scroll bar"));
        }
    }
}