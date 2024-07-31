using ClientPlus.Domain.Common;

namespace ClientPlus.Domain.ValueObject;

public class Email : Common.ValueObject
{
    private Email(string value)
    {
        Value = value;
    }
    
    public string Value { get; private set; }

    public static Result<Email> Create(string value)
    {
        return new Email(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}