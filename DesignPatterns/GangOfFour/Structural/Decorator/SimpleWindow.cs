namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    using System;

    public class SimpleWindow : IWindow
    {
        public string Description { get; set; } = "Simple window";

        public void Draw()
        {
            Console.WriteLine("Drawing simple window.");
        }
    }
}