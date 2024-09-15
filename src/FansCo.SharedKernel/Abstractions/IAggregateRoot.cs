namespace FansCo.SharedKernel.Abstractions;

public interface IAggregateRoot<TId, TState> : IDomainEntity<TId, TState>
    where TId : IValueObject;