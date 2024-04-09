using System.ComponentModel.DataAnnotations;

namespace GeradorDados.Models;

public class TipoEmpresa(int tipoEmpresaId, string nome)
{
    [Key] public int TipoEmpresaId { get; set; } = tipoEmpresaId;
    public string Nome { get; set; } = nome;
}