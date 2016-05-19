namespace DesignPatterns.Behavioral.State
{
    using System;

    public class GreenLight : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new YellowLight();
        }

        public void ReportState()
        {
            Console.WriteLine("Green light");
        }
    }
}