namespace DesignPatterns.Other.Behavioral.Specification
{
    using DesignPatterns.Other.Behavioral.Specification.Base;

    public class InCollectionSpecification : CompositeSpecification<Invoice>
    {
        public override bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.SentToCollectionAgency;
        }
    }
}