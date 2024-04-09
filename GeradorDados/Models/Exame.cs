using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Exame
{
    [Key]
    public int ExameId { get; set; }
    public string TipoExame { get; set; }
    public DateTime? DataExame { get; set; }
    public int? FuncionarioId { get; set; }
    public int? MedicoId { get; set; }

    [ForeignKey("FuncionarioId")]
    public virtual Funcionario Funcionario { get; set; }
    [ForeignKey("MedicoId")]
    public virtual Medico Medico { get; set; }
}