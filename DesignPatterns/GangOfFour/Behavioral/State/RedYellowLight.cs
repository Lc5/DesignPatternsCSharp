namespace DesignPatterns.GangOfFour.Behavioral.State
{
    using System;

    public class RedYellowLight : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new GreenLight();
        }

        public void ReportState()
        {
            Console.WriteLine("Red and yellow light.");
        }
    }
}