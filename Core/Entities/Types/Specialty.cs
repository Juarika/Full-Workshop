using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Specialty : BaseEntity
{
    public string? Description { get; set; }
    public ICollection<PersonSpecialty>? PersonSpecialties { get; set; }
}