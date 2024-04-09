using System.ComponentModel.DataAnnotations;

namespace GeradorDados.Models;

public class TipoRisco
{
    [Key]
    public int TipoRiscoId { get; set; }
    public string Descricao { get; set; }
    
    public TipoRisco(int tipoRiscoId, string descricao)
    {
        TipoRiscoId = tipoRiscoId;
        Descricao = descricao;
    }
}