namespace GeradorDados.Models;

public class TipoEmpresa
{
    public TipoEmpresa(int tipoempresaid, string nome)
    {
        Tipoempresaid = tipoempresaid;
        Nome = nome;
    }

    public int Tipoempresaid { get; set; }
    public string Nome { get; set; }
}