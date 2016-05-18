namespace DesignPatterns.Behavioral.Observer
{
    using System.Collections.Generic;

    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }

        public void Subscribe(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}