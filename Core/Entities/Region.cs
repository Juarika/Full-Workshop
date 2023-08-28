using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Region : BaseEntity
{
    public string? NameRegion { get; set; }
    public int IdStateFk { get; set; }
    public State? State{ get; set; }
    public ICollection<Person>? Persons { get; set; }
}