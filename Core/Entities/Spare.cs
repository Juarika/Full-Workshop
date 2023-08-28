using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Spare : BaseEntity
{
    public string? Description { get; set; }
    public decimal? SparePrice { get; set;}
    public ICollection<DiagnosticSpare>? DiagnosticSpares { get; set; }
}