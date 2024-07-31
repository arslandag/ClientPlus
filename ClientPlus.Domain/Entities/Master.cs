using ClientPlus.Domain.Common;
using ClientPlus.Domain.ValueObject;

namespace ClientPlus.Domain.Entities;

public class Master : Entity
{
    private Master(
        string name,
        string specialization,
        string pozition,
        Phone phone,
        Email email)
    {
        Name = name;
        Specialization = specialization;
        Pozition = pozition;
        Phone = phone;
        Email = email;
    }
    
    public string Name { get; private set; }
    public string Specialization { get; private set; }
    public string Pozition { get; private set; }
    public Phone Phone  { get; private set; }
    public Email Email  { get; private set; }

    public static Result<Master> Create(
        string name,
        string specialization,
        string pozition,
        Phone phone,
        Email email)
    {
        return new Master(
            name,
            specialization,
            pozition,
            phone,
            email);
    }
}