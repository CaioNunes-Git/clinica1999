using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class ClinicaEmpresa
{
    public int? ClinicaId { get; set; }
    public int? EmpresaId { get; set; }

    [ForeignKey("ClinicaId")]
    public virtual Clinica Clinica { get; set; }
    [ForeignKey("EmpresaId")]
    public virtual Empresa Empresa { get; set; }
}