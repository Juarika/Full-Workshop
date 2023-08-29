namespace Core.Entities;

public class DiagnosticSpare
{
    public int IdDiagnosticFk { get; set; }
    public Diagnostic? Diagnostic { get; set; }
    public int IdSpareFk { get; set; }
    public Spare? Spare { get; set; }
    public int Lot { get; set; }
    public bool Approved { get; set; } = false;
}