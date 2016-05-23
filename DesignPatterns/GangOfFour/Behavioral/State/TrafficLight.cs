namespace DesignPatterns.GangOfFour.Behavioral.State
{
    public class TrafficLight
    {
        public ITrafficLightState State { get; set; }

        public void Change()
        {
            this.State.Change(this);
        }

        public void ReportState()
        {
            this.State.ReportState();
        }
    }
}