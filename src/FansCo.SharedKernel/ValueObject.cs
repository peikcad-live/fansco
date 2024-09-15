using FansCo.SharedKernel.Abstractions;

namespace FansCo.SharedKernel;

public abstract record ValueObject : IValueObject
{
    public bool IsValueObject(IValueObject obj)
        => obj is ValueObject valueObject &&
           valueObject == this;
}