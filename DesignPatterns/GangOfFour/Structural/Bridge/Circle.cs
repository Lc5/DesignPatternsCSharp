namespace DesignPatterns.GangOfFour.Structural.Bridge
{
    public class Circle : IShape
    {
        private readonly IDrawingApi drawingAPI;

        private readonly int x;

        private readonly int y;

        private int radius;

        public Circle(int x, int y, int radius, IDrawingApi drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.drawingAPI = drawingAPI;
        }

        public void Draw()
        {
            this.drawingAPI.DrawCircle(this.x, this.y, this.radius);
        }

        public void ResizeByPercentage(int percentage)
        {
            this.radius *= percentage;
        }
    }
}