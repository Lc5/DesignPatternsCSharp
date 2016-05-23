namespace DesignPatterns.GangOfFour.Structural.Flyweight
{
    using System.Collections.Generic;

    public static class CircleFactory
    {
        public static Dictionary<int, Circle> Circles { get; } = new Dictionary<int, Circle>();

        public static Circle GetCircle(int x, int y, int radius, string color)
        {
            const string CircleName = nameof(Circle);
            var hash = new { radius, color, circleName = CircleName }.GetHashCode();

            Circle circle;

            if (!Circles.TryGetValue(hash, out circle))
            {
                circle = new Circle(radius, color);
                Circles.Add(hash, circle);
            }

            circle.X = x;
            circle.Y = y;

            return circle;
        }
    }
}