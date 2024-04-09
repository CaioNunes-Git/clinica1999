using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Atestado
{
    [Key]
    public int AtestadoId { get; set; }
    public DateTime? DataEmissao { get; set; }
    public int? Qtddias { get; set; }
    public int? FuncionarioId { get; set; }
    public int? MedicoId { get; set; }

    [ForeignKey("FuncionarioId")]
    public virtual Funcionario Funcionario { get; set; }
    [ForeignKey("MedicoId")]
    public virtual Medico Medico { get; set; }
}