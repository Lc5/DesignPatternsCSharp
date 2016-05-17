namespace DesignPatterns.Tests.Structural.Adapter
{
    using DesignPatterns.Structural.Adapter;

    using NUnit.Framework;

    [TestFixture]
    public class EBookAdapterTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new Book() },
            new[] { new EBookAdapter(new Kindle()) }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestEBookAdapter(IPaperBook book)
        {
            book.Open();

            book.TurnPage();
        }
    }
}