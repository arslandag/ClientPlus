using ClientPlus.Domain.Common;
using ClientPlus.Domain.ValueObject;

namespace ClientPlus.Domain.Entities;

public class Record
{
    public Record(
        Master master,
        Service service,
        Time time,
        Client client,
        Organization organization)
    {
        Master = master;
        Service = service;
        Time = time;
        Client = client;
        Organization = organization;
    }
    
    public Master Master { get; private set; }
    public Service Service { get; private set; }
    public Time Time { get; private set; }
    public Client Client { get; private set; }
    public Organization Organization { get; private set; }

    public static Result<Record> Create(
        Master master,
        Service service,
        Time time,
        Client client,
        Organization organization)
    {
        return new Record(
            master,
            service,
            time,
            client,
            organization);
    }
}