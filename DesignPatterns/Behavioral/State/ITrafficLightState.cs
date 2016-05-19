namespace DesignPatterns.Behavioral.State
{
    public interface ITrafficLightState
    {
        void Change(TrafficLight trafficLight);

        void ReportState();
    }
}