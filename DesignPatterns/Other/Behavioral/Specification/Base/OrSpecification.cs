namespace DesignPatterns.Other.Behavioral.Specification.Base
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> left;

        private readonly ISpecification<T> right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override bool IsSatisfiedBy(T entity)
        {
            return this.left.IsSatisfiedBy(entity) || this.right.IsSatisfiedBy(entity);
        }
    }
}