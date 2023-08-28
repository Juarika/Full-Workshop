namespace Core.Entities;

public class Vehicle : BaseEntity
{
    public string? Plate { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public double? Km { get; set; }
    public int IdPersonFk { get; set; }
    public Person? Person { get; set; }
    public int IdColorFk { get; set; }
    public Color? Color { get; set; }
}