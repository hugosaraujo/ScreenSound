using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes:Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloOpcaoMenu("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que você quer saber os detalhes: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine();
            Console.WriteLine($"A média da banda {nomeDaBanda} é {banda.Media}");
            /**
            *Criação de uma variável para fazer uma validação da informação; 
            *Se a banda tiver mais de 1 album, o plural é adicionado
            *Procurar por "C# ternary operator" na documentação do C#
            *https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            **/
            Console.WriteLine($"Foram registrados {Album.QuantidadeAlbuns} albuns");
            Console.WriteLine("Discografia: ");
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
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
