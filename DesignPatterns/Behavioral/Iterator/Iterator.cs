namespace DesignPatterns.Behavioral.Iterator
{
    public class Iterator : IIterator
    {
        private Collection collection;

        private int current = 0;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        public object CurrentItem()
        {
            return this.collection[current];
        }

        public object First()
        {
            return this.collection[0];
        }

        public bool IsDone()
        {
            return this.current >= collection.Count;
        }

        public object Next()
        {
            object result = null;

            if (++this.current < this.collection.Count)
            {
                result = this.collection[this.current];
            }

            return result;
        }
    }
}