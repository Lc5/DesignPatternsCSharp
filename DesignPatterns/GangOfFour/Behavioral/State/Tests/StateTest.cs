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

            // OUTPUT: Red light.

            // OUTPUT: Red and yellow light.

            // OUTPUT: Green light.

            // OUTPUT: Yellow light.

            // OUTPUT: Red light.

            // OUTPUT: Red and yellow light.

            // OUTPUT: Green light.

            // OUTPUT: Yellow light.

            // OUTPUT: Red light.
        }
    }
}