using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Spare : BaseTypeEntity
{
    public decimal? SparePrice { get; set;}
    public ICollection<DiagnosticSpare>? DiagnosticSpares { get; set; }
}