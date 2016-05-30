namespace DesignPatterns.Other.Behavioral.Specification.Base
{
    public class AndNotSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> left;

        private readonly ISpecification<T> right;

        public AndNotSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return this.left.IsSatisfiedBy(entity) && !this.right.IsSatisfiedBy(entity);
        }
    }
}