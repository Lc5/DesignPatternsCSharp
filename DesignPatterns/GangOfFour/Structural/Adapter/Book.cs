namespace DesignPatterns.GangOfFour.Structural.Adapter
{
    using System;

    public class Book : IPaperBook
    {
        public void Open()
        {
            Console.WriteLine("Opening the book.");          
        }

        public void TurnPage()
        {
            Console.WriteLine("Turning the page.");
        }
    }
}