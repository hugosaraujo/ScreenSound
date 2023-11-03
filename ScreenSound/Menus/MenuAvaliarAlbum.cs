using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum:Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloOpcaoMenu("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];
            Console.Write("Digite o nome do album que quer avaliar: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.WriteLine();
                Console.Write($"Digite a nota que você quer avaliar o album {tituloAlbum}: ");
                Avaliacao notaDoAlbum = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota((notaDoAlbum));
                Console.WriteLine($"Registrando a nota {notaDoAlbum.Nota}. {tituloAlbum} foi avaliado com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{tituloAlbum} não foi encontrado(a)!");
                Console.Write("Pressione alguma tecla para voltar para o Menu...");
                Console.ReadKey();
                Console.Clear();
            } 
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{nomeBanda} não foi encontrado(a)!");
            Console.Write("Pressione alguma tecla para voltar para o Menu...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
