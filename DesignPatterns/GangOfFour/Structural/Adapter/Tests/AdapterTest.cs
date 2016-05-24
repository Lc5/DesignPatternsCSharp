namespace DesignPatterns.GangOfFour.Structural.Adapter.Tests
{
    using DesignPatterns.GangOfFour.Structural.Adapter;

    using NUnit.Framework;

    [TestFixture]
    public class AdapterTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new Book() },
            new[] { new EbookAdapter(new Kindle()) }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestAdapter(IPaperBook book)
        {
            book.Open();

            // Opening the book.

            // Pressing "Start" button.

            book.TurnPage();

            // Turning the page.

            // Pressing "Next page" button.
        }
    }
}