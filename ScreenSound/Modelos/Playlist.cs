namespace ScreenSound.Modelos;

public class Playlist
{
    private List<Musica> _musicas = new List<Musica>();

    public Playlist(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public Genero Genero { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        _musicas.ForEach(musica => Console.WriteLine($"Titulo da Musica: {musica.Faixa}"));
    }
}