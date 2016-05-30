namespace DesignPatterns.Other.Behavioral.Specification.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class SpecificationTest
    {
        [Test]
        public void TestSpecification()
        {
            var invoices = new[]
            {
                new Invoice(1, 199, DateTime.Now),
                new Invoice(2, 99, new DateTime(2010, 01, 24)) { NoticeCount = 3 }
            };

            var sendToCollectionSpecification =
                new OverDueSpecification()
                .And(new NoticeSentSpecification())
                .And(new InCollectionSpecification().Not());

            foreach (var invoice in invoices)
            {
                if (sendToCollectionSpecification.IsSatisfiedBy(invoice))
                {
                    invoice.SendToCollection();
                }
            }

            // OUTPUT: Invoice 2 was sent to collection.
        }
    }
}
