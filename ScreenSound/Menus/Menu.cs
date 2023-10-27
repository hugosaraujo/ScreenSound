namespace ScreenSound.Menus;

public class Menu
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
}
