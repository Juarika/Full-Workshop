using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Email : BaseEntity
{
    public string? Direction { get; set; }
    public int IdEmailTypeFk { get; set; }
    public Email? Email { get; set; }
    public int IdPersonFk { get; set; }
    public Person? Person { get; set; }
}