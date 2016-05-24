namespace DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility;

    using NUnit.Framework;

    [TestFixture]
    public class ChainOfResponsibilityTest
    {
        [TestCase(1)]
        [TestCase(12)]
        [TestCase(23)]
        public void TestChainOfResponsibility(int request)
        {
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            var handler3 = new ConcreteHandler3();

            handler1.Successor = handler2;
            handler2.Successor = handler3;

            handler1.HandleRequest(request);

            // ConcreteHandler1 handled request: 1.

            // ConcreteHandler2 handled request: 12.

            // ConcreteHandler3 handled request: 23.
        }
    }
}