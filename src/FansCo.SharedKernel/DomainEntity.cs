using FansCo.SharedKernel.Abstractions;

namespace FansCo.SharedKernel;

public abstract class DomainEntity<TId, TState> : IDomainEntity<TId, TState>
    where TId : ValueObject
{
    protected DomainEntity(TId id, TState state)
    {
        Id = id;
        DomainState = state;
    }

    public TId Id { get; }

    public TState DomainState { get; }

    public bool IsDomainEntity(TId id) => EqualityComparer<TId>.Default.Equals(id, Id);

    public bool IsDomainEntity(IDomainEntity<TId, TState> entity)
        => ReferenceEquals(entity, this) ||
           IsDomainEntity(entity.Id);

    public override int GetHashCode() => Id.GetHashCode();

    public override bool Equals(object? obj)
        => obj is DomainEntity<TId, TState> entity &&
           IsDomainEntity(entity);

    public static bool operator ==(DomainEntity<TId, TState> a, DomainEntity<TId, TState> b) => a.IsDomainEntity(b);

    public static bool operator !=(DomainEntity<TId, TState> a, DomainEntity<TId, TState> b) => !(a == b);
}