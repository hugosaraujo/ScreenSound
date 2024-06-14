namespace ScreenSound.Modelos.Podcast;

public class Podcast
{
    private List<Episodio> _listaDeEpisodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => _listaDeEpisodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        _listaDeEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}, Apresentado por {Host}");
        foreach(var episodio  in _listaDeEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        _listaDeEpisodios.ForEach(episodio => Console.WriteLine(episodio.Titulo)); 
    }
}
