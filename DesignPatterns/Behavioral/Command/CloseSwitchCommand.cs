namespace DesignPatterns.Behavioral.Command
{
    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable switchable;

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
