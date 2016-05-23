namespace DesignPatterns.GangOfFour.Creational.AbstractFactory
{
    public interface IGuiFactory
    {
        IButton CreateButton();

        IContextMenu CreateContextMenu();

        IWindow CreateWindow();
    }
}