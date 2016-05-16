namespace DesignPatterns.Behavioral.Command
{
    public class OpenSwitchCommand : ICommand
    {
        private ISwitchable switchable;

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
