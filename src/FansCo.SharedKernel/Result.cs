using System.Diagnostics.CodeAnalysis;
using FansCo.SharedKernel.Abstractions;

namespace FansCo.SharedKernel;

public sealed class Result<T> : IResult<T>
{
    [MemberNotNullWhen(true, nameof(Value))]
    [MemberNotNullWhen(false, nameof(Error))]
    public bool IsSuccess { get; private init; }
    
    public T? Value { get; private init; }
    
    public Exception? Error { get; private init; }

    public static Result<T> Ok(T value) => new() {IsSuccess = true, Value = value};

    public static Result<T> Ko(Exception error) => new() {IsSuccess = false, Error = error};
}