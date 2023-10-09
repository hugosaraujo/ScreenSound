class Album
{
    public Album(Banda artista)
    {
        Artista = artista;
    }

    private List<Musica> faixasDoAlbum = new List<Musica>();
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int DuracaoTotal => faixasDoAlbum.Sum(faixa => faixa.Duracao);

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