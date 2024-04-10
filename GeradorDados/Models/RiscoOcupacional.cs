namespace GeradorDados.Models;

public class RiscoOcupacional
{
    public RiscoOcupacional(int riscoocupacionalid, string descricao, int? tiporiscoid)
    {
        Riscoocupacionalid = riscoocupacionalid;
        Descricao = descricao;
        Tiporiscoid = tiporiscoid;
    }

    public int Riscoocupacionalid { get; set; }
    public string Descricao { get; set; }
    public int? Tiporiscoid { get; set; }
}