namespace DesignPatterns.GangOfFour.Behavioral.Memento
{
    using System.Collections.Generic;

    public class CareTaker<T>
    {
        private List<Memento<T>> savedStates = new List<Memento<T>>();

        public void AddMemento(Memento<T> memento)
        {
            this.savedStates.Add(memento);
        }

        public Memento<T> GetMemento(int index)
        {
            return this.savedStates[index];
        }
    }
}