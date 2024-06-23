using ScreenSound.Interfaces;

namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> faixas = new();
    private List<Avaliacao> notas = new();

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeAlbums++;
    }
    public string Nome { get; }
    public List<Genero> Generos { get; set; } = new();
    public double DuracaoTotal => faixas.Sum(musica => musica.DuracaoEmSegundos / 60);
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public int DuracaoTotalMinutos => (int)Math.Ceiling(DuracaoTotal);
    public static int ContadorDeAlbums = 0;

    public void AdcionarFaixa(Musica musica)
    {
        faixas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Album: {Nome}");
        Console.WriteLine($"Duracao: {DuracaoTotalMinutos} minutos\n");    
        foreach (var musica in faixas)
        {
            Console.WriteLine($"Musica - {musica.Faixa}");
        }
    }
}
