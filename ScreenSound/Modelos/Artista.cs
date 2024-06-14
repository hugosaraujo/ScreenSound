using System.Threading.Channels;

namespace ScreenSound.Modelos;

public class Artista
{
    private List<Album> _albums = new();
    private List<int> _notas = new();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media => _notas.Average();

    public void AdicionarAlbum(Album album)
    {
        _albums.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        _notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Lista de Albums de {Nome}");
        _albums.ForEach(
            album => Console.WriteLine($"Nome do Disco: {album.Nome}, Duração{album.DuracaoTotalMinutos}"));
    }
}
