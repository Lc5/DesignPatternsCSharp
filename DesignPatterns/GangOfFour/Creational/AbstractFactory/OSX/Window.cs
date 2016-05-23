namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.OSX
{
    using System;

    public class Window : IWindow
    {
        public void Render()
        {
            Console.WriteLine("Rendering OSX window.");
        }
    }
}