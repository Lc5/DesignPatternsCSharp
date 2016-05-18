namespace DesignPatterns.Behavioral.Memento
{
    using System.Collections.Generic;

    public class CareTaker<T>
    {
        private List<Memento<T>> savedStates = new List<Memento<T>>();

        public void AddMemento(Memento<T> memento)
        {
            savedStates.Add(memento);
        }

        public Memento<T> GetMemento(int index)
        {
            return savedStates[index];
        }
    }
}