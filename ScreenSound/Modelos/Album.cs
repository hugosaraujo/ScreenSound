using ScreenSound.Interfaces;

namespace ScreenSound.Modelos;

internal class Album:IAvaliavel
{
    private List<Musica> faixasDoAlbum = new List<Musica>();
    private List<Avaliacao> notas = new();
 
    public Album(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;
        QuantidadeAlbuns++;
    }

    public string Nome { get; }
    public Artista Artista { get; }
    public int DuracaoTotal => faixasDoAlbum.Sum(faixa => faixa.Duracao);
    public int AnoLancamento { get; set; }
    //posso usar o ano de lançamento para organizar os albuns por ordem cronológica
    public double Media
    {
        get 
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota);
        }
    }

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

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}