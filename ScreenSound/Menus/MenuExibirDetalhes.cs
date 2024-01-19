using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes:Menu
{
    internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        //adicionar um ternário para validar se é um artista masculino ou feminino;
        ExibirTituloOpcaoMenu("Exibir detalhes de artista");
        Console.Write("Digite o nome do Artista que você quer saber os detalhes: ");
        string nomeArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeArtista))
        {
            Artista artista = artistasRegistrados[nomeArtista];
            Console.WriteLine();
            Console.WriteLine($"A média de {nomeArtista} é {artista.Media}");
            /**
            *Criação de uma variável para fazer uma validação da informação; 
            *Se a banda tiver mais de 1 album, o plural é adicionado
            *Procurar por "C# ternary operator" na documentação do C#
            *https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            **/
            Console.WriteLine($"Foram registrados {Album.QuantidadeAlbuns} albuns");
            Console.WriteLine("Discografia: ");
            foreach (Album album in artista.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.Write("Digite qualquer tecla para voltar para o menu principal... ");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{nomeArtista} não foi encontrada!");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
