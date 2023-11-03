using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloOpcaoMenu(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeLetras + 2, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine($"*{titulo}*");
        Console.WriteLine(asteriscos);
        Console.WriteLine();
    }

    internal virtual void Executar(Dictionary<string, Banda> bandaRegistradas)
    {
        Console.Clear();
    }

    public void OpcaoInvalida()
    {
        Console.WriteLine("Opção Inválida!");
        Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal... ");
        Console.ReadKey();
        Console.Clear();
    }
}
