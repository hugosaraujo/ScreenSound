namespace ScreenSound.Modelos;

internal class Playlist
{
    private List<Musica> musicas = new List<Musica>();

    public Playlist(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public Genero Genero { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        musicas.ForEach(musica => Console.WriteLine($"Titulo da Musica: {musica.Faixa}"));
    }
}