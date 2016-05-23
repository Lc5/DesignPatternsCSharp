namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    public interface IWindow
    {
        string Description { get; set; }

        void Draw();
    }
}