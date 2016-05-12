namespace DesignPatterns.Structural.Composite
{
    using System.Collections.Generic;

    using System.Text;

    public class Form : IFormElement
    {
        private List<IFormElement> elements = new List<IFormElement>();

        public string Render(int indent = 0)
        {
            var output = new StringBuilder();

            output.Append(new string(' ', indent) + "<form>\r\n");

            foreach (var element in this.elements)
            {
                output.Append(element.Render(indent + 4));
            }

            output.Append(new string(' ', indent) + "</form>\r\n");

            return output.ToString();
        }

        public void AddElement(IFormElement element)
        {
            this.elements.Add(element);
        }
    }
}
