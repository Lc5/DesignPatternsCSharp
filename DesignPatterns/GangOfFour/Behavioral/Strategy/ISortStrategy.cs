namespace DesignPatterns.GangOfFour.Behavioral.Strategy
{
    using System.Collections.Generic;

    public interface ISortStrategy<T>
    {
        void Sort(List<T> items);
    }
}