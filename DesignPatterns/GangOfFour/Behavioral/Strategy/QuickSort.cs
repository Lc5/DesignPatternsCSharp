namespace DesignPatterns.GangOfFour.Behavioral.Strategy
{
    using System.Collections.Generic;

    public class QuickSort<T> : ISortStrategy<T>
    {
        public void Sort(List<T> items)
        {
            // Default is QuickSort
            items.Sort();
        }
    }
}