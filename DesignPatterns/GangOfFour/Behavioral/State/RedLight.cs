namespace DesignPatterns.GangOfFour.Behavioral.State
{
    using System;

    public class RedLight : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new RedYellowLight();
        }

        public void ReportState()
        {
            Console.WriteLine("Red light.");
        }
    }
}