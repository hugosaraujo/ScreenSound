using System.Net.NetworkInformation;

int opcaoEscolhida = -1;

Dictionary<string, List<int>> listaDeArtistas = new Dictionary<string, List<int>>()
{
    {"Soccer Mommy", new List<int>{10, 8, 6, 8} },
    {"Fleetwood Mac", new List<int>{10, 9, 6, 8} },
    {"Thundercat", new List<int>{10, 8, 6, 8} },
    {"Silk Sonic", new List<int>{10, 8, 6, 8} },
    {"The Beatles", new List<int>{10, 8, 4, 6} },
    {"The Rolling Stones", new List<int>{10, 8, 6, 8} },
    {"The Who", new List<int>{10, 8, 6, 8} },
    {"The Doors", new List<int>{10, 8, 6, 8} }
};

while (opcaoEscolhida != 0)
{
    ExibirMenuDeOpcoes();
};


void exibirBanner()
{
    string banner = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";

    string mensagemBoasVindas = "Boas vindas ao Screen Sound";

    Console.WriteLine(banner);
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine();

}

void ExibirMenuDeOpcoes()
{
    exibirBanner();

    Console.WriteLine("Digite 1 para registrar uma banda ou artista");
    Console.WriteLine("Digite 2 para mostrar artistas registrados");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da banda");
    Console.WriteLine("Digite 0 para fechar a aplicação\n");

    Console.Write("Selecione uma da opções disponíveis: ");
    opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarArtista();
            break;
        case 2:
            MostrarArtistas();
            break;
        case 3:
            AvaliarArtista();
            break;
        case 4:
            ExibirMedia();
            break;
        case 0:
            FecharAplicacao();
            break;
        default:
            ExibirOpcaoInvalida();
            break;
    }
}

void ExibirTitulo(string titulo)
{
    int tamanhoTitulo = titulo.Length;
    string asteriscos = new string('*', tamanhoTitulo + 2);

    Console.WriteLine(asteriscos);
    Console.WriteLine($"*{titulo}*");
    Console.WriteLine(asteriscos);
    Console.WriteLine();
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTitulo("Registrar Artista");
    Console.Write("Digite do nome do Artista: ");
    string artista = Console.ReadLine()!;
    listaDeArtistas.Add(artista, new List<int>());
    Console.WriteLine($"\n{artista} foi registrado com sucesso!!!");
    Thread.Sleep(2000);
    Console.Clear();
}

void MostrarArtistas()
{
    Console.Clear();
    ExibirTitulo("Exibir Artistas Registrados");
    foreach (var artista in listaDeArtistas.Keys) 
    {
        Console.WriteLine(artista);
    }
    Console.WriteLine();
    Console.Write("Pressione qualquer tecla para retornar para o menu principal: ");
    Console.ReadKey();
    Console.Clear();
}

void AvaliarArtista()
{
    Console.Clear();
    ExibirTitulo("Avaliar Artista");
    Console.Write("Digite o nome do Artista: ");
    string artista = Console.ReadLine()!;
    if (listaDeArtistas.ContainsKey(artista))
    {
        Console.Write("Digite a nota do Artista: ");
        int avaliacao = int.Parse(Console.ReadLine()!);
        listaDeArtistas[artista].Add(avaliacao);
        Console.WriteLine($"\nVocê avaliou {artista} com a nota {avaliacao}!!!");
    }
    else
    {
        Console.WriteLine("\nArtista não encontrado!!!");
    }
    Console.WriteLine();
    Console.Write("Pressione qulaquer tecla para retornar para o menu principal: ");
    Console.ReadKey();
    Console.Clear();
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Exibir Média do Artista");
    Console.Write("Digite o nome do Artista: ");
    string artista = Console.ReadLine()!;
    if (listaDeArtistas.ContainsKey(artista))
    {
        List<int> avaliacoes = listaDeArtistas[artista];
        double media = avaliacoes.Average();
        Console.WriteLine($"\n{artista} tem uma média de {media} avaliações");
    }
    else
    {
        Console.WriteLine("\nArtista não encontrado!!!");
    }
    Console.WriteLine();
    Console.Write("Pressione qualquer tecla para retornar para o menu principal: ");
    Console.ReadKey();
    Console.Clear();
}

void FecharAplicacao()
{
    Console.Clear();
    Console.WriteLine("Fechando a aplicação...");
    Thread.Sleep(2000);
    Console.WriteLine("\nTchau Tchau!!");
}

void ExibirOpcaoInvalida()
{
    Console.Clear();
    ExibirTitulo("Você selecionou uma opção inválida.");
    Console.Write("Pressione qualquer tecla para voltar para o Menu Principal");
    Console.ReadKey();
    Console.Clear();
}