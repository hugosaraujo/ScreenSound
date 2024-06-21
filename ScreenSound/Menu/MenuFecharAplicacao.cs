using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuFecharAplicacao : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtista)
    {
        Console.WriteLine("\nFechando a aplicação...");
        Thread.Sleep(2000);
        Console.WriteLine("\nTchau Tchau!!");
    }
}
