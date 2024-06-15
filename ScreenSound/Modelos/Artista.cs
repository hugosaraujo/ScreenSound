namespace ScreenSound.Modelos;

public class Artista
{
    private List<Album> albums = new();
    private List<int> notas = new();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media => notas.Average();
    public List<Album> Albums => albums;

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Artista: {Nome}, Média: {Media}");
        Console.WriteLine($"Lista de Albums de {Nome}");
        albums.ForEach(
            album => Console.WriteLine($"Nome do Disco: {album.Nome}"));
    }
}
