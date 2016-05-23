namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.OSX
{
    public class GuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new Button();
        }

        public IContextMenu CreateContextMenu()
        {
            return new ContextMenu();
        }

        public IWindow CreateWindow()
        {
            return new Window();
        }
    }
}