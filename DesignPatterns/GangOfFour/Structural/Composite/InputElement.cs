namespace DesignPatterns.GangOfFour.Structural.Composite
{
    public class InputElement : IFormElement
    {
        public string Render(int indent = 0)
        {
            return new string(' ', indent) + "<input type=\"text\" />\r\n";
        }
    }
}