namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        object CurrentItem();

        object First();

        bool IsDone();

        object Next();
    }
}