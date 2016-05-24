namespace DesignPatterns.GangOfFour.Behavioral.State.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.State;

    using NUnit.Framework;

    [TestFixture]
    public class StateTest
    {
        [Test]
        public void TestState()
        {
            var trafficLight = new TrafficLight { State = new RedLight() };
            trafficLight.ReportState();

            for (var i = 0; i < 8; i++)
            {
                trafficLight.Change();
                trafficLight.ReportState();
            }

            // Red light.

            // Red and yellow light.

            // Green light.

            // Yellow light.

            // Red light.

            // Red and yellow light.

            // Green light.

            // Yellow light.

            // Red light.
        }
    }
}