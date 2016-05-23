namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.Windows
{
    using System;

    public class Button : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows button.");
        }
    }
}