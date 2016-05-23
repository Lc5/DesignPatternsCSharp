namespace DesignPatterns.GangOfFour.Behavioral.Interpreter
{
    public class NumberExpression : IExpression
    {
        private readonly int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return this.number;
        }
    }
}