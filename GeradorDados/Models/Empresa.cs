using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Empresa
{
    [Key]
    public int EmpresaId { get; set; }
    [StringLength(14)]
    public string Cnpj { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    [StringLength(20)]
    public string Telefone { get; set; }
    public int? TipoEmpresaId { get; set; }

    [ForeignKey("TipoEmpresaId")]
    public virtual TipoEmpresa TipoEmpresa { get; set; }
}