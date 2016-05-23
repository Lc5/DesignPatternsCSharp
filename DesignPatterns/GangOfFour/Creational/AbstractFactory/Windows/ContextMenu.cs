namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.Windows
{
    using System;

    public class ContextMenu : IContextMenu
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows context menu.");
        }
    }
}