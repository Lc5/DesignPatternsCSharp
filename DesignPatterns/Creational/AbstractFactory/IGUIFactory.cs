namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IGuiFactory
    {
        IButton CreateButton();

        IContextMenu CreateContextMenu();

        IWindow CreateWindow();
    }
}