namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        IContextMenu CreateContextMenu();
        IWindow CreateWindow();
    }
}
