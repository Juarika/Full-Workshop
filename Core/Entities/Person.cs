namespace Core.Entities;

public class Person
{
    public int? IdPerson { get; set; }
    public string? NamePerson { get; set; }
    public string? SurnamePerson { get; set; }
    public DateTime Birthdate { get; set; }
    public int IdPersonTypeFk { get; set; }
    public PersonType? PersonType { get; set; }
    public int IdRegionFk { get; set; }
    public Region? Region { get; set; }
    // public ICollection<Producto> Productos { get; set; } = new HashSet<Producto>();
    // public ICollection<ProductoPerson>? ProductosPerson { get; set; }
}