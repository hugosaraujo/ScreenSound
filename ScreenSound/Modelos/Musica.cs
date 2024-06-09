using System.Runtime.CompilerServices;

namespace ScreenSound.Modelos;
public class Musica
{
    public string faixa;
    public string artista;
    public int duracaoEmSegundos;
    public bool disponívelNoPlano;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Titulo: {faixa} - Artista: {artista}");
    }

}
