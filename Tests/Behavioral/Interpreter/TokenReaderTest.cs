namespace DesignPatterns.Tests.Behavioral.Interpreter
{
    using System.Collections.Generic;

    using DesignPatterns.Behavioral.Interpreter;

    using NUnit.Framework;

    [TestFixture]
    public class TokenReaderTest
    {
        [TestCase("+ 10 2", 12)]
        [TestCase("+ - 10 2 3", 11)]
        [TestCase("- + 10 5 - 8 2", 9)]
        public void TestReadToken(string tokenString, int expectedResult)
        {
            var tokenList = new List<string>(tokenString.Split(' '));
            var expression = new TokenReader().ReadToken(tokenList);

            Assert.That(expression.Interpret(), Is.EqualTo(expectedResult));
        }
    }
}