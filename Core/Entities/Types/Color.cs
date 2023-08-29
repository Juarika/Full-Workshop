using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Types;

public class Color : BaseTypeEntity
{
    public ICollection<Vehicle>? Vehicles { get; set; }
}