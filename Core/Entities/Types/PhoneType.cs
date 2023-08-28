using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class PhoneType : BaseTypeEntity
{
    public ICollection<Phone>? Phones { get; set; }
}