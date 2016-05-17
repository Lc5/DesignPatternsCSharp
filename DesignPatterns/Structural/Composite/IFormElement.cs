namespace DesignPatterns.Structural.Composite
{
    public interface IFormElement
    {
        string Render(int indent = 0);
    }
}