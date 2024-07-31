using ClientPlus.Domain.Common;

namespace ClientPlus.Domain.ValueObject;

public class Phone : Common.ValueObject
{
    private Phone(string value)
    {
        Value = value;
    }
    
    public string Value { get; private set; }

    public static Result<Phone> Create(string value)
    {
        return new Phone(value);
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}