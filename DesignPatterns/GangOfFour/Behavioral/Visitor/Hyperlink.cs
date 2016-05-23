namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class Hyperlink : DocumentPart
    {
        public Hyperlink(string text, string url) : base(text)
        {
            this.Url = url;
        }

        public string Url { get; private set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}