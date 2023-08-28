using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Phone : BaseEntity
{
    public string? Number { get; set; }
    public int IdPhoneTypeFk { get; set; }
    public Phone? Phone { get; set; }
    public int IdPersonFk { get; set; }
    public Person? Person { get; set; }
}