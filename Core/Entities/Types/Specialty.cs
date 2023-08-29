using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Types;

public class Specialty : BaseTypeEntity
{
    public ICollection<PersonSpecialty>? PersonSpecialties { get; set; }
}