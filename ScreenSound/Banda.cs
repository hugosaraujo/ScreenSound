class Banda
{
    private List<Album> albunsDaBanda = new List<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albunsDaBanda.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        Console.WriteLine();
        foreach (var album in albunsDaBanda)
        {
            Console.WriteLine($"Album: {album.Nome}");
            Console.WriteLine($"Duração Total - {album.DuracaoTotal} segundos");
        }
    }
}