using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        base.Executar(listaDeArtistas);
        ExibirTitulo("Exibir Média da Artista");
        Console.Write("Digite o nome do Artista que quer saber os detalhes: ");
        string nomeArtista = Console.ReadLine()!;
        if (listaDeArtistas.ContainsKey(nomeArtista))
        {
            Artista artista = listaDeArtistas[nomeArtista];
            artista.ExibirDiscografia();
        }
        else
        {
            Console.WriteLine("Artista não encontrado");
        }
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para voltar para o menu principal: ");
        Console.ReadKey();
    }
}
