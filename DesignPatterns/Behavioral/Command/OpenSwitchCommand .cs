namespace DesignPatterns.Behavioral.Command
{
    public class OpenSwitchCommand : ICommand
    {
        private readonly ISwitchable switchable;

        public OpenSwitchCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Execute()
        {
            this.switchable.PowerOff();
        }
    }
}