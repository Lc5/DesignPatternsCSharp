namespace DesignPatterns.Tests.Behavioral.Strategy
{
    using DesignPatterns.Behavioral.Strategy;

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

            list.SortStrategy = new MergeSort<string>();
            list.Sort();

            list.SortStrategy = new ShellSort<string>();
            list.Sort();
        }
    }
}