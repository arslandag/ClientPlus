using ClientPlus.Domain.Common;
using ClientPlus.Domain.ValueObject;

namespace ClientPlus.Domain.Entities;

public class Client
{
    public Client(
        string name,
        Phone phone,
        Email email = null,
        string comment = null)
    {
        Name = name;
        Phone = phone;
        Email = email;
        Comment = comment;
    }
    
    public string Name { get; private set; }
    public Phone Phone  { get; private set; }
    public Email Email  { get; private set; }
    public string Comment { get; private set; }
    
    public static Result<Client> Create(
        string name,
        Phone phone,
        Email email = null,
        string comment = null)
    {
        return new Client(
            name,
            phone,
            email,
            comment);
    }
}
