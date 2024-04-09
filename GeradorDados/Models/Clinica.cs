using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Clinica
{
    [Key]
    public int ClinicaId { get; set; }
    [StringLength(14)]
    public string Cnpj { get; set; }
    public string Nome { get; set; }
    public int? EmpresaId { get; set; }

    [ForeignKey("EmpresaId")]
    public virtual Empresa Empresa { get; set; }
}