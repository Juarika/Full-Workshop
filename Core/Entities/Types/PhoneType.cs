using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Types;

public class PhoneType : BaseTypeEntity
{
    public ICollection<Phone>? Phones { get; set; }
}