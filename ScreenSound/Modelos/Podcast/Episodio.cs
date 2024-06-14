namespace ScreenSound.Modelos.Podcast;

public class Episodio
{
    private List<string> _convidados = new List<string>();

    public Episodio(
        int ordem,
        string titulo, 
        int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo => 
        $"{Ordem} - {Titulo}, Tempo do Episódio: {Duracao} minutos - Convidados {string.Join(", ", _convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        _convidados.Add(convidado);
    }
}
