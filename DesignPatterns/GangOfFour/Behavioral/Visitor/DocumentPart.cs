namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public abstract class DocumentPart
    {
        public DocumentPart(string text)
        {
            this.Text = text;
        }

        public abstract void Accept(IVisitor visitor);

        public string Text { get; private set; }
    }
}