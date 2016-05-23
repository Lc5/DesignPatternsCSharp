namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class HtmlVisitor : IVisitor
    {
        public string Output { get; private set; }

        public void Visit(BoldText documentPart)
        {
            this.Output += "<b>" + documentPart.Text + "</b>";
        }

        public void Visit(Hyperlink documentPart)
        {
            this.Output += "<a href=\"" + documentPart.Url + "\">" + documentPart.Text + "</a>";
        }

        public void Visit(PlainText documentPart)
        {
            this.Output += documentPart.Text;
        }      
    }
}