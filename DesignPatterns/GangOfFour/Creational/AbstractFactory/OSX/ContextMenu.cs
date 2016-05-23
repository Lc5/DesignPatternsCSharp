namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.OSX
{
    using System;

    public class ContextMenu : IContextMenu
    {
        public void Render()
        {
            Console.WriteLine("Rendering OSX context menu.");
        }
    }
}