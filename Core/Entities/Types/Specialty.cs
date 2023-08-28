using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Specialty : BaseTypeEntity
{
    public ICollection<PersonSpecialty>? PersonSpecialties { get; set; }
}