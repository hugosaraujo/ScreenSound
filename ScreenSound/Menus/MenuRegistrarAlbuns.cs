using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbuns:Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloOpcaoMenu("Registrar Album");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Digite o album que quer registrar: ");
            string nomeDoAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(banda, nomeDoAlbum));
            /**
             * Espaço para implementar a lógica de registrar um album
             *     */
            Console.WriteLine($"{nomeDoAlbum} da {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
