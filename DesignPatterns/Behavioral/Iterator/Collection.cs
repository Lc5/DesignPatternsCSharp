namespace DesignPatterns.Behavioral.Iterator
{
    using System.Collections.Generic;

    public class Collection : ICollection
    {
        private List<object> items = new List<object>();

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}