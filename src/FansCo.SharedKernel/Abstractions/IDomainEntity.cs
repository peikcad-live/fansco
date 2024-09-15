namespace FansCo.SharedKernel.Abstractions;

public interface IDomainEntity<TId, TState>
    where TId : IValueObject
{
    TId Id { get; }
    
    TState DomainState { get; }
    
    bool IsDomainEntity(TId id);
    
    bool IsDomainEntity(IDomainEntity<TId, TState> entity);
}