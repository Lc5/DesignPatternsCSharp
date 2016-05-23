namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}