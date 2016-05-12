namespace DesignPatterns.Structural.Decorator
{
    public class SimpleWindow : IWindow
    {
        public string Description { get; set; } = "Simple window";

        public void Draw()
        {
            //Draw simple window
        }
    }
}
