using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Funcionario
{
    [Key]
    public int FuncionarioId { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime? DataNascimento { get; set; }
    public int? CargoId { get; set; }
    public int? EmpresaId { get; set; }

    [ForeignKey("CargoId")]
    public virtual Cargo Cargo { get; set; }
    [ForeignKey("EmpresaId")]
    public virtual Empresa Empresa { get; set; }
}