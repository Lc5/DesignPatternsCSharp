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

            // OUTPUT: Opening the book.

            // OUTPUT: Pressing "Start" button.

            book.TurnPage();

            // OUTPUT: Turning the page.

            // OUTPUT: Pressing "Next page" button.
        }
    }
}