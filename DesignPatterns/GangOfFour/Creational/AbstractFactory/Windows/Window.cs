namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.Windows
{
    using System;

    public class Window : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows window.");
        }
    }
}