using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class Menu
{

    public static void ExibirBanner()
    {
        string banner = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

        string mensagemBoasVindas = "Boas vindas ao Screen Sound";

        Console.WriteLine(banner);
        Console.WriteLine(mensagemBoasVindas);
        Console.WriteLine();
    }

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

