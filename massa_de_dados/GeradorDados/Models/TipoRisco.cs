namespace GeradorDados.Models;

public class TipoRisco
{
    public TipoRisco(int tiporiscoid, string descricao)
    {
        Tiporiscoid = tiporiscoid;
        Descricao = descricao;
    }

    public int Tiporiscoid { get; set; }
    public string Descricao { get; set; }
}