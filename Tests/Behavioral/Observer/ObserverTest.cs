namespace DesignPatterns.Tests.Behavioral.Observer
{
    using DesignPatterns.Behavioral.Observer;

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

            subject.Unsubscribe(observer2);

            subject.Notify();
        }
    }
}