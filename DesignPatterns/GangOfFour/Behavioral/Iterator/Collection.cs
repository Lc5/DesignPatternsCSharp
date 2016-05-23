namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    using System.Collections.Generic;

    public class Collection : ICollection
    {
        private List<object> items = new List<object>();

        public object this[int index]
        {
            get { return this.items[index]; }
            set { this.items.Insert(index, value); }
        }

        public int Count
        {
            get { return this.items.Count; }
        }

        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}