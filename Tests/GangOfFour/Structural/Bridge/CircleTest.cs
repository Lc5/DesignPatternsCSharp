namespace DesignPatterns.Tests.GangOfFour.Structural.Bridge
{
    using System;

    using DesignPatterns.GangOfFour.Structural.Bridge;

    using NUnit.Framework;

    [TestFixture]
    public class CircleTest
    {
        [TestCase(typeof(DrawingApi1))]
        [TestCase(typeof(DrawingApi2))]
        public void TestDraw(Type drawingApiType)
        {
            var drawingApi = (IDrawingApi)Activator.CreateInstance(drawingApiType);

            var circle = new Circle(0, 0, 10, drawingApi);

            circle.Draw();
        }
    }
}