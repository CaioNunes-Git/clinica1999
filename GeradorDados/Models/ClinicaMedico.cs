using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class ClinicaMedico
{
    public int? ClinicaId { get; set; }
    public int? MedicoId { get; set; }

    [ForeignKey("ClinicaId")]
    public virtual Clinica Clinica { get; set; }
    [ForeignKey("MedicoId")]
    public virtual Medico Medico { get; set; }
}