using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
        int tamanhoTitulo = titulo.Length;
        string asteriscos = new string('*', tamanhoTitulo + 2);

        Console.WriteLine(asteriscos);
        Console.WriteLine($"*{titulo}*");
        Console.WriteLine(asteriscos);
        Console.WriteLine();
    }

    public virtual void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        Console.Clear();
    }
}

