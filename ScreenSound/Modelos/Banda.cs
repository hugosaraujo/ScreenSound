namespace ScreenSound.Modelos;

internal class Banda:IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new();
    public Banda(string nome)
    {
        Nome = nome;
    }

    
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota);
        }
    }
    public List<Album> Albuns => albuns;


    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        Console.WriteLine();
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome}");
            Console.WriteLine($"Duração Total - {album.DuracaoTotal} segundos");
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}