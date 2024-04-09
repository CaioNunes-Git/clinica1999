using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class RiscoOcupacional (int RiscoOcupacionalId, string Descricao, int? TipoRiscoId)
{
    [Key] public int RiscoOcupacionalId = RiscoOcupacionalId;

    [ForeignKey("TipoRiscoId")]
    public virtual TipoRisco TipoRisco { get; set; }
}