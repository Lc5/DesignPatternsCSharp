namespace DesignPatterns.Behavioral.Iterator
{
    public interface ICollection
    {
        IIterator CreateIterator();
    }
}