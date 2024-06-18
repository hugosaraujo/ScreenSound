namespace ScreenSound.Modelos;

internal class Album
{
    private List<Musica> faixas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome; 
    }
    public string Nome { get; }
    public List<Genero> Generos { get; set; } = new();
    public double DuracaoTotal => faixas.Sum(musica => musica.DuracaoEmSegundos / 60);
    public int DuracaoTotalMinutos => (int)Math.Ceiling(DuracaoTotal);

    public void AdcionarFaixa(Musica musica)
    {
        faixas.Add(musica);
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
