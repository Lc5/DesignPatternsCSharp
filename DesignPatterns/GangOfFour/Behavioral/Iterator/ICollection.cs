namespace DesignPatterns.GangOfFour.Behavioral.Iterator
{
    public interface ICollection
    {
        IIterator CreateIterator();
    }
}