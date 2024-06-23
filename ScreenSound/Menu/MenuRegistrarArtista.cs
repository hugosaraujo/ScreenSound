using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuRegistrarArtista : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        base.Executar(listaDeArtistas);
        ExibirTitulo("Registrar Artista");
        Console.Write("Digite do nome do Artista: ");
        string nomeArtista = Console.ReadLine()!;
        Artista artista = new(nomeArtista);
        listaDeArtistas.Add(nomeArtista, artista);
        Console.WriteLine($"\n{nomeArtista} foi registrado com sucesso!!!");
        Console.Write("Pressione qualquer tecla para voltar para o menu principal: ");
        Console.ReadKey();
    }
}
