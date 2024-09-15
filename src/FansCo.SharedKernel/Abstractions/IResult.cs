using System.Diagnostics.CodeAnalysis;

namespace FansCo.SharedKernel.Abstractions;

public interface IResult<out T>
{
    [MemberNotNullWhen(true, nameof(Value))]
    [MemberNotNullWhen(false, nameof(Error))]
    public bool IsSuccess { get; }
    
    public T? Value { get; }
    
    public Exception? Error { get; }
}