using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas:Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloOpcaoMenu("Exibindo bandas registradas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Nome: {banda}");
        }
        Console.Write("Pressione alguma tecla para voltar para o Menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
