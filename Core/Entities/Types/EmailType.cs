using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class EmailType : BaseEntity
{
    public string? Description { get; set; }
    public ICollection<Email>? Emails { get; set; }
}