namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    public class CloseSwitchCommand : ICommand
    {
        private readonly ISwitchable switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Execute()
        {
            this.switchable.PowerOff();
        }
    }
}