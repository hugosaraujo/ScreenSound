using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirArtistas : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        base.Executar(listaDeArtistas);
        Console.Clear();
        ExibirTitulo("Exibir Artistas Registrados");
        foreach (var artista in listaDeArtistas.Keys)
        {
            Console.WriteLine(artista);
        }
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para retornar para o menu principal: ");
        Console.ReadKey();
    }
}
