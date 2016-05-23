namespace DesignPatterns.GangOfFour.Behavioral.Memento
{
    public class Originator<T>
    {
        public T State { get; set; }

        public void RestoreFromMemento(Memento<T> memento)
        {
            this.State = memento.State;
        }

        public Memento<T> SaveToMemento()
        {
            return new Memento<T>(this.State);
        }        
    }
}