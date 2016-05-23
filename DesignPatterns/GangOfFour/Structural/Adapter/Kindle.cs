namespace DesignPatterns.GangOfFour.Structural.Adapter
{
    using System;

    public class Kindle : IEbook
    {
        public void PressNext()
        {
            Console.WriteLine("Pressing \"Next page\" button.");
        }

        public void PressStart()
        {
            Console.WriteLine("Pressing \"Start\" button."); 
        }
    }
}