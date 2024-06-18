using System.Runtime.CompilerServices;

namespace ScreenSound.Modelos;
internal class Musica
{
    public Musica(string faixa, Artista artista)
    {
        Faixa = faixa;
        Artista = artista;
    }

    public string Faixa { get; }
    public Artista Artista { get;  }
    public int DuracaoEmSegundos { get; set;}
    public bool DisponívelNoPlano { get; set; }
    public Genero GeneroMusical { get; set; }
    public string Descricao => $"{Faixa} By {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Titulo: {Faixa}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {DuracaoEmSegundos}");
        if(DisponívelNoPlano)
        {
            Console.WriteLine("Disponível no Plano");
        } 
        else
        {
            Console.WriteLine("Adquira o plano+");
        }
    }

}
