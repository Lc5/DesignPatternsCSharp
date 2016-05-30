namespace DesignPatterns.Other.Behavioral.Specification.Base
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public ISpecification<T> And(ISpecification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }

        public ISpecification<T> AndNot(ISpecification<T> other)
        {
            return new AndNotSpecification<T>(this, other);
        }

        public abstract bool IsSatisfiedBy(T entity);

        public ISpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }

        public ISpecification<T> OrNot(ISpecification<T> other)
        {
            return new OrNotSpecification<T>(this, other);
        }
    }
}