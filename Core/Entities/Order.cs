namespace Core.Entities;

public class Order : BaseEntity 
{
    public DateTime RegisterDate { get; set; } = DateTime.Now;
    public string? DiagnosticClients { get; set; }
    public string? State { get; set;}
    public int IdClientFk { get; set; }
    public Person? Client { get; set; }
    public int IdManagerFk { get; set; }
    public Person? Manager { get; set; }
    public int IdVehicleFk { get; set; }
    public Vehicle? Vehicle { get; set; }
}