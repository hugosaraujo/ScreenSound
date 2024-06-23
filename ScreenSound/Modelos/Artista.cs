using ScreenSound.Interfaces;

namespace ScreenSound.Modelos;

internal class Artista : IAvaliavel
{
    private List<Album> albums = new();
    private List<Avaliacao> notas = new();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albums => albums;

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Artista: {Nome} -> Média: {Media}");
        Console.WriteLine($"Lista de Albums de {Nome}");
        albums.ForEach(
            album => Console.WriteLine($"Nome do Disco: {album.Nome} -> {album.Media}"));
    }
}
