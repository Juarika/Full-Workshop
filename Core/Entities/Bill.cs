namespace Core.Entities;

public class Bill : BaseEntity
{
    public decimal Subtotal { get; set; }
    public decimal Iva { get; set; }
    public decimal LaborValue { get; set; }
    public decimal Total { get; set; }
    public int IdClientFk { get; set; }
    public Person? Client { get; set; }
    public int IdOrderFk { get; set; }
    public Order? Order { get; set; }
}