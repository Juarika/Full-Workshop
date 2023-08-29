using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Types;

public class PersonType : BaseTypeEntity
{
    public ICollection<Person>? Persons { get; set; }
}