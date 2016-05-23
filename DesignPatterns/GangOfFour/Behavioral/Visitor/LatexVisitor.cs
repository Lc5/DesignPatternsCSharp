namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class LatexVisitor : IVisitor
    {
        public string Output { get; private set; }

        public void Visit(BoldText documentPart)
        {
            this.Output += "\\textbf{" + documentPart.Text + "}";
        }

        public void Visit(Hyperlink documentPart)
        {
            this.Output += "\\href{" + documentPart.Url + "}{" + documentPart.Text + "}";
        }

        public void Visit(PlainText documentPart)
        {
            this.Output += documentPart.Text;
        }    
    }
}