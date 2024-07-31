using ClientPlus.Domain.Common;

namespace ClientPlus.Domain.ValueObject;

public class Time : Common.ValueObject
{
    public DateTime Value { get; private set; }

    private Time(DateTime value)
    {
        Value = value;
    }

    public static Result<Time> Create(DateTime value)
    {
        return new Time(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}