using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Types;

public class EmailType : BaseTypeEntity
{
    public ICollection<Email>? Emails { get; set; }
}