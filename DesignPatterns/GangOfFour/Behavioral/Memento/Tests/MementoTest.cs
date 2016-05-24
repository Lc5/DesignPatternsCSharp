namespace DesignPatterns.GangOfFour.Behavioral.Memento.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.Memento;

    using NUnit.Framework;

    [TestFixture]
    public class MementoTest
    {
        [Test]
        public void TestMemento()
        {
            var careTaker = new CareTaker<string>();
            var originator = new Originator<string>();

            originator.State = "State 1";
            careTaker.AddMemento(originator.SaveToMemento());

            originator.State = "State 2";
            careTaker.AddMemento(originator.SaveToMemento());

            originator.State = "State 3";
            originator.RestoreFromMemento(careTaker.GetMemento(1));

            Assert.That(originator.State, Is.EqualTo("State 2"));
        }
    }
}