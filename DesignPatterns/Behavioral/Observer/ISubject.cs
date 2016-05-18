namespace DesignPatterns.Behavioral.Observer
{
    public interface ISubject
    {
        void Notify();

        void Subscribe(IObserver observer);

        void Unsubscribe(IObserver observer);
    }
}