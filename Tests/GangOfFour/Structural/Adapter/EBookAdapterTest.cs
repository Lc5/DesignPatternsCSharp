namespace DesignPatterns.Tests.GangOfFour.Structural.Adapter
{
    using DesignPatterns.GangOfFour.Structural.Adapter;

    using NUnit.Framework;

    [TestFixture]
    public class EbookAdapterTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new Book() },
            new[] { new EbookAdapter(new Kindle()) }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestEbookAdapter(IPaperBook book)
        {
            book.Open();

            book.TurnPage();
        }
    }
}