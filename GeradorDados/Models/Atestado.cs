namespace GeradorDados.Models;

public class Atestado
{
    public int Atestadoid { get; set; }
    public DateTime? Dataemissao { get; set; }
    public int? Qtddias { get; set; }
    public int? Funcionarioid { get; set; }
    public int? Medicoid { get; set; }
}