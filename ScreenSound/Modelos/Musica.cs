using System.Runtime.CompilerServices;

namespace ScreenSound.Modelos;
public class Musica
{

    public string Faixa { get; set;}
    public string Artista { get; set; }
    public int DuracaoEmSegundos { get; set;}
    public bool DisponívelNoPlano { get; set; }
    public string Descricao => $"{Faixa} By {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Titulo: {Faixa}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {DuracaoEmSegundos}");
    }

}
