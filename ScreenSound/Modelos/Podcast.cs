namespace ScreenSound.Modelos;

internal class Podcast
{
    List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O Podcast {Nome} é apresentado por {Host}");
        Console.WriteLine($"Eis uma lista de episódios de {Nome}");
        foreach (Episodio episodio in episodios.OrderBy(episodio => episodio.Ordem))
        { 
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Foram registrados {TotalEpisodios} episódios de {Nome}");
    }
}