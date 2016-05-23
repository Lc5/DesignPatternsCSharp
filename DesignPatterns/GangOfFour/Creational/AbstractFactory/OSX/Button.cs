namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.OSX
{
    using System;

    public class Button : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering OSX button.");
        }
    }
}