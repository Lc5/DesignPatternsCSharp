namespace DesignPatterns.Structural.Bridge
{
    public class Circle : IShape
    {
        private int x;
        private int y;
        private int radius;
        private IDrawingAPI drawingAPI;

        public Circle(int x, int y, int radius, IDrawingAPI drawingAPI)
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
