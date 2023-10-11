namespace ScreenSound.Modelos;

class Banda
{
    private List<Album> albunsDaBanda = new List<Album>();
    public Banda(string nome)
    {
        Nome = nome;
    }

    
    public string Nome { get; }


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