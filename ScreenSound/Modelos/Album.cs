namespace ScreenSound.Modelos;

public class Album
{
    private List<Musica> _faixas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome; 
    }
    public string Nome { get; }
    public List<Genero> Generos { get; set; } = new();
    public int DuracaoTotal => _faixas.Sum(musica => musica.DuracaoEmSegundos);

    public void AdcionarFaixa(Musica musica)
    {
        _faixas.Add(musica);
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Album: {Nome}");
        Console.WriteLine($"Duracao: {DuracaoTotal}\n");    
        foreach (var musica in _faixas)
        {
            Console.WriteLine($"Musica - {musica.Faixa}");
        }
    }
}
