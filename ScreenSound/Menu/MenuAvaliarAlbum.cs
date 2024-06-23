using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        base.Executar(listaDeArtistas);
        ExibirTitulo("Avaliar Album");
        Console.Write("Digite o nome do Artista do Album que quer avaliar: ");
        string nomeArtista = Console.ReadLine()!;
        if (listaDeArtistas.ContainsKey(nomeArtista))
        {
            Artista artista = listaDeArtistas[nomeArtista];
            Console.Write("Digite o nome do album que quer avaliar: ");
            string nomeAlbum = Console.ReadLine()!;
            if(artista.Albums.Any(a => a.Nome.Equals(nomeAlbum)))
            {
                Album album = artista.Albums.First(a => a.Nome.Equals(nomeAlbum));
                Console.Write("Digite a nota para o album: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"{album.Nome} foi avaliado com a nota {nota.Nota}");
            }
        } else
        {
            Console.WriteLine("Artista não encontrado!");
        }
        Console.Write("\nPressione qualquer tecla para voltar para o Menu Principal: ");
        Console.ReadLine();
    }
}
