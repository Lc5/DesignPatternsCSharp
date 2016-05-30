namespace DesignPatterns.Other.Behavioral.Specification
{
    using DesignPatterns.Other.Behavioral.Specification.Base;

    public class NoticeSentSpecification : CompositeSpecification<Invoice>
    {
        public override bool IsSatisfiedBy(Invoice invoice)
        {
            return invoice.NoticeCount >= 3;
        }
    }
}