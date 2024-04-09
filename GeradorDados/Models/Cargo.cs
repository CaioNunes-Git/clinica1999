using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDados.Models;

public class Cargo (int cargoId, string Nome, int? RiscoOcupacionalId)
{
    [Key] public int CargoId { get; set; } = cargoId;

    [ForeignKey("RiscoOcupacionalId")]
    public virtual RiscoOcupacional RiscoOcupacional { get; set; }
}