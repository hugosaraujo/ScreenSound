using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloOpcaoMenu("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeArtista))
        {
            Artista artista = artistasRegistrados[nomeArtista];
            Console.Write("Digite o nome do album que quer avaliar: ");
            string tituloAlbum = Console.ReadLine()!;
            if (artista.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = artista.Albuns.First(a => a.Nome.Equals(tituloAlbum));
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
            Console.WriteLine($"{nomeArtista} não foi encontrado(a)!");
            Console.Write("Pressione alguma tecla para voltar para o Menu...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
