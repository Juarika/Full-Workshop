namespace Core.Entities;

public class Diagnostic : BaseEntity
{
    public string Description { get; set; }
    public int IdOrderFk { get; set; }
    public Order? Order { get; set; }
    public int IdEmployeeFk { get; set; }
    public Person? Person { get; set; }
}