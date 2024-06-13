using System.Threading.Channels;

namespace ScreenSound.Modelos;

public class Artista
{
    private List<Album> _albums = new();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        _albums.Add(album);
    }

    public void ExibeFichaTecnica()
    {
        Console.WriteLine($"Lista de Albums de {Nome}");
        _albums.ForEach(album => Console.WriteLine(album.Nome));
    }
}
