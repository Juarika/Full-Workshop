using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class PersonType : BaseTypeEntity
{
    public ICollection<Person>? Persons { get; set; }
}