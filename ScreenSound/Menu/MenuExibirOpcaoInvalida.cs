using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirOpcaoInvalida : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtista)
    {
        base.Executar(listaDeArtista);
        ExibirTitulo("Você selecionou uma opção inválida.");
        Console.Write("Pressione qualquer tecla para voltar para o Menu Principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}
