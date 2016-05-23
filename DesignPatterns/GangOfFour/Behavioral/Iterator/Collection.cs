namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    using System.Collections.Generic;

    public class Collection : ICollection
    {
        private readonly List<object> items = new List<object>();

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return this.items[index];
            }

            set
            {
                this.items.Insert(index, value);
            }
        }

        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}