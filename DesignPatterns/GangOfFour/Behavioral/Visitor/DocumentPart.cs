namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public abstract class DocumentPart
    {
        public DocumentPart(string text)
        {
            this.Text = text;
        }

        public string Text { get; private set; }

        public abstract void Accept(IVisitor visitor);
    }
}