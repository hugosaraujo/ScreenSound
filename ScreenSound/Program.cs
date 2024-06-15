using ScreenSound.Modelos;
using System.Runtime;

int opcaoEscolhida = -1;

Artista jt = new("Justin Timberlake");
jt.AdicionarNota(6);
jt.AdicionarNota(7);

Artista sm = new("Soccer Mommy");
sm.AdicionarNota(10);
sm.AdicionarNota(8);

Artista mac = new("Mac DeMarco");
mac.AdicionarNota(8);
mac.AdicionarNota(10);
mac.AdicionarNota(7);

Dictionary<string, Artista> listaDeArtistas = new()
{
    {sm.Nome, sm },
    {mac.Nome, mac },
    {jt.Nome, jt }
};

while (opcaoEscolhida != 0)
{
    ExibirMenuDeOpcoes();
};


void ExibirBanner()
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
    Console.Clear();
    ExibirBanner();

    Console.WriteLine("Digite 1 para registrar uma banda ou artista");
    Console.WriteLine("Digite 2 para registrar um album de um artista");
    Console.WriteLine("Digite 3 para mostrar artistas registrados");
    Console.WriteLine("Digite 4 para avaliar um artita");
    Console.WriteLine("Digite 5 para exibir os detalhes de um artista");
    Console.WriteLine("Digite 0 para fechar a aplicação\n");

    Console.Write("Selecione uma da opções disponíveis: ");
    opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarArtista();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarArtistas();
            break;
        case 4:
            AvaliarArtista();
            break;
        case 5:
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
    string nomeArtista = Console.ReadLine()!;
    Artista artista = new(nomeArtista);
    listaDeArtistas.Add(nomeArtista, artista);
    Console.WriteLine($"\n{nomeArtista} foi registrado com sucesso!!!");
    Thread.Sleep(2000);
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTitulo("Registro de álbuns");
    Console.Write("Digite o artista cujo álbum deseja registrar: ");
    string nomeArtista = Console.ReadLine()!;
    
    if (listaDeArtistas.ContainsKey(nomeArtista))
    {
        Artista artista = new(nomeArtista);
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        artista.AdicionarAlbum(new Album(tituloAlbum));
        Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeArtista} foi registrado com sucesso!");
    } 
    else
    {
        Console.WriteLine("Artista não encontrado no sistema");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar para o Menu Principal");
    Console.ReadKey();
};

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
}

void AvaliarArtista()
{
    Console.Clear();
    ExibirTitulo("Avaliar Artista");
    Console.Write("Digite o nome do Artista: ");
    string nomeArtista = Console.ReadLine()!;
    if (listaDeArtistas.ContainsKey(nomeArtista))
    {
        Artista artista = new(nomeArtista);
        Console.Write("Digite a nota do Artista: ");
        int avaliacao = int.Parse(Console.ReadLine()!);
        artista.AdicionarNota(avaliacao);
        Console.WriteLine($"\nVocê avaliou {nomeArtista} com a nota {avaliacao}!!!");
    }
    else
    {
        Console.WriteLine("\nArtista não encontrado!!!");
    }
    Console.WriteLine();
    Console.Write("Pressione qulaquer tecla para retornar para o menu principal: ");
    Console.ReadKey();
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Exibir Média da Artista");
    Console.Write("Digite o nome do Artista que quer saber os detalhes: ");
    string nomeArtista = Console.ReadLine()!;
    if (listaDeArtistas.ContainsKey(nomeArtista)){
        Artista artista = listaDeArtistas[nomeArtista];
        Console.WriteLine($"Artista: {nomeArtista}, Media: {artista.Media}");
    } 
    else
    {
        Console.WriteLine("Artista não encontrado");
    }
    Console.WriteLine();
    Console.Write("Pressione qualquer tecla para voltar para o menu principal: ");
    Console.ReadKey();
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