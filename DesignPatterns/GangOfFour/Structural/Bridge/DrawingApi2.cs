namespace DesignPatterns.GangOfFour.Structural.Bridge
{
    using System;

    public class DrawingApi2 : IDrawingApi
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine("Drawing circle.");
        }
    }
}