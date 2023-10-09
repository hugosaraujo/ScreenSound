class Podcast
{
    List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; set; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        TotalEpisodios++;
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O Podcast {Nome} é apresentado por {Host}");
        Console.WriteLine($"Eis uma lista de episódios de {Nome}");
        //ordenar lista de episódios pela ordem
        foreach (Episodio episodio in episodios)
        { 
            Console.WriteLine($"{episodio.Ordem} - {episodio.Titulo}");
        }
    }
}