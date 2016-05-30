namespace DesignPatterns.Other.Behavioral.Specification.Base
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> other;

        public NotSpecification(ISpecification<T> other)
        {
            this.other = other;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return !this.other.IsSatisfiedBy(entity);
        }
    }
}