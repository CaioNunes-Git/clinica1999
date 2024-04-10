namespace GeradorDados.Models;

public class Cargo
{
    public Cargo(int cargoid, string nome, int? riscoocupacionalid)
    {
        Cargoid = cargoid;
        Nome = nome;
        Riscoocupacionalid = riscoocupacionalid;
    }

    public int Cargoid { get; set; }
    public string Nome { get; set; }
    public int? Riscoocupacionalid { get; set; }
}