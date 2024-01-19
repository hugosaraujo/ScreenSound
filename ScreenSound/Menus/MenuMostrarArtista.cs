using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtista:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        Console.Clear();
        ExibirTituloOpcaoMenu("Exibindo bandas registradas");
        foreach (string artista in artistasRegistrados.Keys)
        {
            Console.WriteLine($"Nome: {artista}");
        }
        Console.Write("Pressione alguma tecla para voltar para o Menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
