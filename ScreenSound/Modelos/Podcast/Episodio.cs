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

    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => 
        $"{Ordem} - {Titulo}, Tempo do Episódio: {Duracao} minutos - Convidados {string.Join(", ", _convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        _convidados.Add(convidado);
    }
}
