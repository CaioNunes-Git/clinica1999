namespace GeradorDados.Models;

public class ExameTipo
{
    public ExameTipo(int exametipoid, string descricao)
    {
        Exametipoid = exametipoid;
        Descricao = descricao;
    }

    public int Exametipoid { get; set; }
    public string Descricao { get; set; }
}