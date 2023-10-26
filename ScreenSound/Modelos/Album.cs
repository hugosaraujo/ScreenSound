namespace ScreenSound.Modelos;

internal class Album
{
    private List<Musica> faixasDoAlbum = new List<Musica>();
 
    public Album(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
        QuantidadeAlbuns++;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int DuracaoTotal => faixasDoAlbum.Sum(faixa => faixa.Duracao);
    public static int QuantidadeAlbuns = 0;

    public void AdicionarMusica(Musica faixa)
    {
        faixasDoAlbum.Add(faixa);
    }

    public void ExibirFaixasDoAlbum()
    {
        Console.WriteLine($"Faixas do álbum {Nome}");
        Console.WriteLine();
        foreach (var faixa in faixasDoAlbum)
        {
            Console.WriteLine($"Faixa: {faixa.Nome}");
        }
        Console.WriteLine($"Você salvou {DuracaoTotal} segundos de músicas do album {Nome} de {Artista.Nome}");
    }   

}