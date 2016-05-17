namespace DesignPatterns.Structural.Bridge
{
    public interface IShape
    {
        void Draw();

        void ResizeByPercentage(int percentage);
    }
}