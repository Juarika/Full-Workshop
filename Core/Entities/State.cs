using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class State : BaseEntity
{
    public string? NameState { get; set; }
    public int IdCountryFk { get; set; }
    public Country? Country { get; set; }
    public ICollection<Region>? Regions { get; set; }
}