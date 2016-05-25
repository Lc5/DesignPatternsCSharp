namespace DesignPatterns.GangOfFour.Behavioral.Observer.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.Observer;

    using NUnit.Framework;

    [TestFixture]
    public class ObserverTest
    {
        [Test]
        public void TestObserver()
        {
            var subject = new Subject();

            var observer1 = new Observer("Observer 1");
            var observer2 = new Observer("Observer 2");

            subject.Subscribe(observer1);
            subject.Subscribe(observer2);

            subject.Notify();

            // OUTPUT: Observer 1 receieved an update.

            // OUTPUT: Observer 2 receieved an update.

            subject.Unsubscribe(observer2);

            subject.Notify();

            // OUTPUT: Observer 1 receieved an update.
        }
    }
}