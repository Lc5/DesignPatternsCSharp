namespace DesignPatterns.Tests.Structural.Bridge
{
    using System;

    using DesignPatterns.Structural.Bridge;

    using NUnit.Framework;

    [TestFixture]
    class CircleTest
    {
        [TestCase(typeof(DrawingAPI1))]
        [TestCase(typeof(DrawingAPI2))]
        public void TestDraw(Type drawingApiType)
        {
            var drawingApi = (IDrawingAPI)Activator.CreateInstance(drawingApiType);

            var circle = new Circle(0, 0, 10, drawingApi);

            circle.Draw();
        }
    }
}
