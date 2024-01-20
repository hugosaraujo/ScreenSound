using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarArtista:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistaRegistrados )
    {
        base.Executar(artistaRegistrados);
        ExibirTituloOpcaoMenu("Resgitro de artista");
        Console.Write("Digite o nome da artista que queira registrar: ");
        string nomeArtista = Console.ReadLine()!;
        Console.Write("Digite uma breve resumo da biografia da banda: ");
        string bioArtista = Console.ReadLine()!;
        Artista artista = new(nomeArtista, bioArtista);
        artistaRegistrados.Add(nomeArtista, artista);
        Console.WriteLine($"{nomeArtista} foi registrado(a) com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
