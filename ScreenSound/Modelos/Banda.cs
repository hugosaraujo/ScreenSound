namespace ScreenSound.Modelos;

internal class Banda
{
    private List<Album> albunsDaBanda = new List<Album>();
    private List<int> notas = new();
    public Banda(string nome)
    {
        Nome = nome;
    }

    
    public string Nome { get; }
    public double Media => notas.Average();


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
    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }
}