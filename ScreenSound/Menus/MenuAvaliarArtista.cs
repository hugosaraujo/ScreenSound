using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarArtista:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloOpcaoMenu("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeDoArtista))
        {
            Artista artista = artistasRegistrados[nomeDoArtista];
            Console.Write("Digite a nota da banda: ");
            Avaliacao notaArtista = Avaliacao.Parse(Console.ReadLine()!);
            artista.AdicionarNota((notaArtista));
            Console.WriteLine($"Registrando a nota {notaArtista.Nota}. A {nomeDoArtista} foi avaliado(a) com sucesso!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{nomeDoArtista} não foi encontrado(a)!");
            Console.Write("Pressione alguma tecla para voltar para o Menu...");
            Console.ReadKey();
            Console.Clear();
        }
        Thread.Sleep(2000);
        Console.Clear();
    }
}
