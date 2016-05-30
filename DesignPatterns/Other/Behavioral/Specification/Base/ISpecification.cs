namespace DesignPatterns.Other.Behavioral.Specification.Base
{
    public interface ISpecification<T>
    {
        ISpecification<T> And(ISpecification<T> other);

        ISpecification<T> AndNot(ISpecification<T> other);

        bool IsSatisfiedBy(T entity);

        ISpecification<T> Not();

        ISpecification<T> Or(ISpecification<T> other);

        ISpecification<T> OrNot(ISpecification<T> other);
    }
}