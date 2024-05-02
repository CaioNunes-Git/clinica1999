namespace GeradorDados.Models;

public class Cargo
{
    public Cargo(int cargoid, string nome, int numeroNaoUtilizado)
    {
        Cargoid = cargoid;
        Nome = nome;
    }

    public int Cargoid { get; set; }
    public string Nome { get; set; }
}