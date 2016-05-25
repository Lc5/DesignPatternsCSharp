namespace DesignPatterns.GangOfFour.Behavioral.Strategy.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.Strategy;

    using NUnit.Framework;

    [TestFixture]
    public class StrategyTest
    {
        [Test]
        public void TestStrategy()
        {
            var sortingStrategy = new QuickSort<string>();
            var list = new SortedList<string>(sortingStrategy);

            list.Items.AddRange(new[] { "xyz", "abc", "ghi", "def" });
            list.Sort();

            // OUTPUT: Sorting list using QuickSort.

            list.SortStrategy = new MergeSort<string>();
            list.Sort();

            // OUTPUT: Sorting list using MergeSort.

            list.SortStrategy = new ShellSort<string>();
            list.Sort();

            // OUTPUT: Sorting list using ShellSort.
        }
    }
}