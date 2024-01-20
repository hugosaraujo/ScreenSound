using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtistas:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloOpcaoMenu("Exibindo artistas registradas");
        foreach (var artista in artistasRegistrados.Keys)
        {
            Console.WriteLine($"Nome: {artista}");
        }
        Console.Write("Pressione qualquer tecla para voltar para o Menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
