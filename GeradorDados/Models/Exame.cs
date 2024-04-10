namespace GeradorDados.Models;

public class Exame
{
    public int Exameid { get; set; }
    public int? Exametipoid { get; set; }
    public DateTime? Dataexame { get; set; }
    public int? Funcionarioid { get; set; }
    public int? Medicoid { get; set; }
}