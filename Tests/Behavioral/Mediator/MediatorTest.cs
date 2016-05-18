namespace DesignPatterns.Tests.Behavioral.Mediator
{
    using DesignPatterns.Behavioral.Mediator;

    using NUnit.Framework;

    [TestFixture]
    class MediatorTest
    {
        [Test]
        public void TestMediator()
        {
            var mediator = new Mediator<string>();

            var colleague1 = new Colleague<string>("Colleague 1");
            var colleague2 = new Colleague<string>("Colleague 2");
            var colleague3 = new Colleague<string>("Colleague 3");

            mediator.Register(colleague1);
            mediator.Register(colleague2);
            mediator.Register(colleague3);

            colleague1.SendMessage(mediator, "Test message 1");
        }
    }
}