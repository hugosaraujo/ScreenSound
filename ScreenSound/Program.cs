using System.Net.NetworkInformation;

int opcaoEscolhida = -1;

//List<string> listaDeArtistas = new List<string> { "Silk Sonic!", "Thundercat", "Fleetwood Mac" };
Dictionary<string, List<int>> listaDeArtistas = new Dictionary<string, List<int>>();

while (opcaoEscolhida != 0)
{
    ExibirMenuDeOpcoes();
}



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
    
    switch(opcaoEscolhida)
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
            ExibirTituloOpcao(opcaoEscolhida);
            Thread.Sleep(2000);
            Console.Clear();
            break;
        case 0:
            ExibirTituloOpcao(opcaoEscolhida);
            Console.WriteLine("Encerrando a aplicação!!!");
            break;
        default: Console.WriteLine("Você selecionou uma opção inválida");
            break;
    }
}

void ExibirTituloOpcao(int titulo)
{
    
    Console.WriteLine($"Você selecionou a opção {titulo}");
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
    foreach(var artista in listaDeArtistas.Keys)
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
    if(listaDeArtistas.ContainsKey(artista))
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

