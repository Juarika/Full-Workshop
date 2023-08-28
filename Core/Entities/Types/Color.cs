using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Color : BaseTypeEntity
{
    public ICollection<Vehicle>? Vehicles { get; set; }
}