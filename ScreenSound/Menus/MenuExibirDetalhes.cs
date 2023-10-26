using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes
{
    void ExibirTituloOpcaoMenu(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeLetras + 2, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine($"*{titulo}*");
        Console.WriteLine(asteriscos);
        Console.WriteLine();
    }
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloOpcaoMenu("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que você quer saber os detalhes: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine();
            Console.WriteLine($"A média da banda {nomeDaBanda} é {banda.Media}");
            Console.WriteLine($"Foram registrados {Album.QuantidadeAlbuns} albuns");
            /**
             * Espaço reservado para completar função
             */
            Console.Write("Digite alguma tecla para voltar para o menu principal... ");
            Console.ReadKey();
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
