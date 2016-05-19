namespace DesignPatterns.Tests.Behavioral.State
{
    using DesignPatterns.Behavioral.State;

    using NUnit.Framework;

    [TestFixture]
    public class StateTest
    {
        [Test]
        public void TestState()
        {
            var trafficLight = new TrafficLight  { State = new RedLight() };
            trafficLight.ReportState();

            for (var i = 0; i < 8; i++)
            {
                trafficLight.Change();
                trafficLight.ReportState();
            }
        }
    }
}