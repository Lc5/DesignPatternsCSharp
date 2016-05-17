namespace DesignPatterns.Tests.Structural.Decorator
{
    using DesignPatterns.Structural.Decorator;

    using NUnit.Framework;

    [TestFixture]
    public class WindowDecoratorTest
    {
        [Test]
        public void TestWindowDecorator()
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