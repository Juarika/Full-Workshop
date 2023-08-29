namespace Core.Entities;

public class PersonSpecialty
{
    public int IdPersonFk { get; set; }
    public Person? Person { get; set; }
    public int IdSpecialtyFk { get; set; }
    public Specialty? Specialty { get; set; }
}