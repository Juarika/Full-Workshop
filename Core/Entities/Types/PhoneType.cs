using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class PhoneType : BaseEntity
{
    public string? Description { get; set; }
    public ICollection<Phone>? Phones { get; set; }
}