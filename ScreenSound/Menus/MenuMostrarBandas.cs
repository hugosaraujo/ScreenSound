using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas:Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloOpcaoMenu("Exibindo bandas registradas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Nome: {banda}");
        }
        Console.Write("Pressione alguma tecla para sair");
        Console.ReadKey();
        Console.Clear();
    }
}
