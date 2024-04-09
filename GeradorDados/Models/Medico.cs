using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Medico
{
    [Key]
    public int MedicoId { get; set; }
    [StringLength(10)]
    public string Crm { get; set; }
    public string Nome { get; set; }
    public int? ClinicaId { get; set; }

    [ForeignKey("ClinicaId")]
    public virtual Clinica Clinica { get; set; }
}