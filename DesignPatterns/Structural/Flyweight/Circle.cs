namespace DesignPatterns.Structural.Flyweight
{
    public class Circle : IShape
    {
        private string color;

        private int radius;

        public Circle(int radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public void Draw()
        {
            // Draw circle  
        }
    }
}