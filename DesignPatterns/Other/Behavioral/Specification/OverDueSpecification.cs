namespace DesignPatterns.Other.Behavioral.Specification
{
    using System;

    using DesignPatterns.Other.Behavioral.Specification.Base;

    public class OverDueSpecification : CompositeSpecification<Invoice>
    {
        public override bool IsSatisfiedBy(Invoice invoice)
        {
            return (DateTime.Now - invoice.DueDate).Days >= 30;
        }
    }
}