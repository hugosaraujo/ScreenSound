using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbuns:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloOpcaoMenu("Registrar Album");
        Console.Write("Digite o nome da banda: ");
        string nomeArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeArtista))
        {
            Console.Write("Digite o album que quer registrar: ");
            string nomeDoAlbum = Console.ReadLine()!;
            Artista artista = artistasRegistrados[nomeArtista];
            artista.AdicionarAlbum(new Album(artista, nomeDoAlbum));
            /**
             * Espaço para implementar a lógica de registrar um album
             *     */
            Console.WriteLine($"{nomeDoAlbum} da {nomeArtista} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"A banda {nomeArtista} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
