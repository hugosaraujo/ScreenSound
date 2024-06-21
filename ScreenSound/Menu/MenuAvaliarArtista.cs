using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuAvaliarArtista : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        base.Executar(listaDeArtistas);
        ExibirTitulo("Avaliar Artista");
        Console.Write("Digite o nome do Artista: ");
        string nomeArtista = Console.ReadLine()!;
        if (listaDeArtistas.ContainsKey(nomeArtista))
        {
            Artista artista = listaDeArtistas[nomeArtista];
            Console.Write("Digite a nota do Artista: ");
            Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
            artista.AdicionarNota(avaliacao);
            Console.WriteLine($"\nVocê avaliou {nomeArtista} com a nota {avaliacao.Nota}!!!");
        }
        else
        {
            Console.WriteLine("\nArtista não encontrado!!!");
        }
        Console.WriteLine();
        Console.Write("Pressione qulaquer tecla para retornar para o menu principal: ");
        Console.ReadKey();
    }
}
