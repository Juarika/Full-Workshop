using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Color : BaseEntity
{
    public string? Description { get; set; }
    public ICollection<Vehicle>? Vehicles { get; set; }
}