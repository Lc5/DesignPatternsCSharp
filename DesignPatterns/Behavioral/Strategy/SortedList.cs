namespace DesignPatterns.Behavioral.Strategy
{
    using System.Collections.Generic;

    public class SortedList<T>
    {
        public List<T> Items { get; } = new List<T>();

        public ISortStrategy<T> SortStrategy { get; set; }

        public SortedList(ISortStrategy<T> sortStrategy)
        {
            this.SortStrategy = sortStrategy;
        }

        public void Sort()
        {
            this.SortStrategy.Sort(this.Items);
        }
    }
}