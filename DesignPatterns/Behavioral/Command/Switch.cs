namespace DesignPatterns.Behavioral.Command
{
    public class Switch
    {
        ICommand closeCommand;
        ICommand openCommand;

        public Switch(ICommand closeCommand, ICommand openCommand)
        {
            this.closeCommand = closeCommand;
            this.openCommand = openCommand;
        }

        public void Close()
        {
            this.closeCommand.Execute();
        }

        public void Open()
        {
            this.openCommand.Execute();
        }
    }
}
