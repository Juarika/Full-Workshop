using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class EmailType : BaseTypeEntity
{
    public ICollection<Email>? Emails { get; set; }
}