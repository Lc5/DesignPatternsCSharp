namespace DesignPatterns.GangOfFour.Structural.Composite
{
    public class TextElement : IFormElement
    {
        public string Render(int indent = 0)
        {
            return new string(' ', indent) + "Text element\r\n";
        }
    }
}