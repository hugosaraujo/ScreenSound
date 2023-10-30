using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda:Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloOpcaoMenu("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Digite a nota da banda: ");
            Avaliacao notaDaBanda = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota((notaDaBanda));
            Console.WriteLine($"Registrando a nota {notaDaBanda.Nota}. A {nomeDaBanda} foi avaliado(a) com sucesso!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{nomeDaBanda} não foi encontrado(a)!");
            Console.Write("Pressione alguma tecla para voltar para o Menu...");
            Console.ReadKey();
            Console.Clear();
        }
        Thread.Sleep(2000);
        Console.Clear();
    }
}
