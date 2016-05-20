namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(BoldText documentPart);

        void Visit(Hyperlink documentPart);

        void Visit(PlainText documentPart);
    }
}