namespace DesignPatterns.GangOfFour.Behavioral.Memento
{
    public class Memento<T>
    {
        public T State { get; set; }

        public Memento(T state)
        {
            this.State = state;
        }
    }
}