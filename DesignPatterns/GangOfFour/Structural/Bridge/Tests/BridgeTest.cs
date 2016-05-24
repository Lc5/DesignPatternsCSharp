namespace DesignPatterns.GangOfFour.Structural.Bridge.Tests
{
    using DesignPatterns.GangOfFour.Structural.Bridge;

    using NUnit.Framework;

    [TestFixture]
    public class BridgeTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new DrawingApi1() },
            new[] { new DrawingApi2() }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestBridge(IDrawingApi drawingApi)
        {
            var circle = new Circle(0, 0, 10, drawingApi);

            circle.Draw();

            // Drawing circle.
        }
    }
}