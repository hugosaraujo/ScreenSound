using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair:Menu
{
    internal override void Executar(Dictionary<string, Artista> bandasRegistradas)
    {
        Console.WriteLine();
        Console.WriteLine("Obrigado por usar o Screen Sound");
        Console.WriteLine("Para fechar a aplicação, pressione qualquer tecla");
        Console.ReadKey();
    }
}
