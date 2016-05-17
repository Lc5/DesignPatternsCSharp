namespace DesignPatterns.Behavioral.Interpreter
{
    public class AddExpression : IExpression
    {
        private readonly IExpression leftExpression;

        private readonly IExpression rightExpression;

        public AddExpression(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return this.leftExpression.Interpret() + this.rightExpression.Interpret();
        }
    }
}