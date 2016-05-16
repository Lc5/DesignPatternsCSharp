namespace DesignPatterns.Behavioral.Interpreter
{
    using System.Collections.Generic;

    public class TokenReader
    {
        public IExpression ReadToken(List<string> tokenList)
        {
            return this.ReadNextToken(tokenList);
        }

        private IExpression ReadNextToken(List<string> tokenList)
        {
            int i;

            if (int.TryParse(tokenList[0], out i))
            {
                tokenList.RemoveAt(0);

                return new NumberExpression(i);
            }

            return this.ReadNonTerminal(tokenList);
        }

        private IExpression ReadNonTerminal(List<string> tokenList)
        {
            var token = tokenList[0];
            tokenList.RemoveAt(0);

            var left = this.ReadNextToken(tokenList);
            var right = this.ReadNextToken(tokenList);

            switch (token)
            {
                case "+":
                    return new AddExpression(left, right);
                case "-":
                    return new SubtractExpression(left, right);
                default:
                    return null;
            }
        }
    }
}
