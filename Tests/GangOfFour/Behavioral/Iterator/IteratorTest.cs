namespace DesignPatterns.Tests.GangOfFour.Behavioral.Iterator
{
    using DesignPatterns.GangOfFour.Behavioral.Iterator;

    using NUnit.Framework;

    [TestFixture]
    public class IteratorTest
    {
        [Test]
        public void TestIterator()
        {
            var numbers = new[] { 11, 22, 33, 44 };

            var collection = new Collection { [0] = numbers[0], [1] = numbers[1], [2] = numbers[2], [3] = numbers[3] };

            var iterator = collection.CreateIterator();
            var i = 0;

            for (var item = iterator.First(); !iterator.IsDone(); item = iterator.Next(), ++i)
            {
                Assert.That(item, Is.EqualTo(numbers[i]));
            }
        }
    }
}