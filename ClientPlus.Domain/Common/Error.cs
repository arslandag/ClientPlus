namespace ClientPlus.Domain.Common;

public class Error
{
    public static readonly Error None = new(string.Empty, string.Empty);

    private const string Separetor = "||";

    public string Code { get; }
    public string Messege { get; }

    public Error(string code, string messege)
    {
        Code = code;
        Messege = messege;
    }

    public string Serialize()
    {
        return $"{Code}{Separetor}{Messege}";
    }

    public static Error Deserialize(string serialize)
    {
        var data = serialize.Split([Separetor], StringSplitOptions.RemoveEmptyEntries);

        if (data.Length < 2)
            throw new($"Invalid error serialization: {serialize}");
            
        return new(data[0], data[1]);
    }
}