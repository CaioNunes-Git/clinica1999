namespace GeradorDados.Models;

public class Funcionario
{
    public int Funcionarioid { get; set; }
    public string Nome { get; set; }
    public DateTime? Datanascimento { get; set; }
    public int? Cargoid { get; set; }
    public int? Empresaid { get; set; }
}