namespace FansCo.SharedKernel.Abstractions;

public interface IRepository<T, in TId, TState>
    where T : IAggregateRoot<TId, TState>
    where TId : IValueObject
{
    Task<IResult<T>> Create(T entity, CancellationToken cancellationToken = default);
    
    Task<IResult<T>> ReadById(TId id, CancellationToken cancellationToken = default);

    Task<IResult<T>> Update(T entity, CancellationToken cancellationToken = default);

    Task<IResult<T>> DeleteById(TId id, CancellationToken cancellationToken = default);
}