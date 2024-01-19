using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarArtista:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistaRegistrados )
    {
        base.Executar(artistaRegistrados);
        ExibirTituloOpcaoMenu("Resgitro de Banda");
        Console.Write("Digite o nome da banda que queira registrar: ");
        string nomeArtista = Console.ReadLine()!;
        //Console.WriteLine("Digite uma breve resumo da biografia da banda");
        //string bioArtista = Console.ReadLine()!;
        Artista artista = new(nomeArtista);
        artistaRegistrados.Add(nomeArtista, artista);
        Console.WriteLine($"{nomeArtista} foi registrado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
