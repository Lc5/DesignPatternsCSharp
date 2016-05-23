namespace DesignPatterns.GangOfFour.Behavioral.State
{
    using System;

    public class YellowLight : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new RedLight();    
        }

        public void ReportState()
        {
            Console.WriteLine("Yellow light");
        }
    }
}