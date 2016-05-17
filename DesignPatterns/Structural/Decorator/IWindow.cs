namespace DesignPatterns.Structural.Decorator
{
    public interface IWindow
    {
        string Description { get; set; }

        void Draw();
    }
}