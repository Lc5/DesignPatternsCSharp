namespace DesignPatterns.GangOfFour.Behavioral.Strategy
{
    using System;
    using System.Collections.Generic;

    public class MergeSort<T> : ISortStrategy<T>
    {
        public void Sort(List<T> items)
        {
            Console.WriteLine("Sorting list using merge sort.");
        }
    }
}