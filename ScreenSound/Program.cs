using ScreenSound.Menu;
using ScreenSound.Modelos;

int opcaoEscolhida = -1;

Artista jt = new("Justin Timberlake");
jt.AdicionarNota(new Avaliacao(6));
jt.AdicionarNota(new Avaliacao(7));

Artista sm = new("Soccer Mommy");
sm.AdicionarNota(new Avaliacao(10));
sm.AdicionarNota(new Avaliacao(8));

Artista mac = new("Mac DeMarco");
mac.AdicionarNota(new Avaliacao(8));
mac.AdicionarNota(new Avaliacao(10));
mac.AdicionarNota(new Avaliacao(7));

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

    Menu acessoMenu; 

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarArtista();
            break;
        case 2:
            acessoMenu = new MenuRegistrarAlbum();
            acessoMenu.Executar(listaDeArtistas);
            break;
        case 3:
            acessoMenu = new MenuExibirArtistas();
            acessoMenu.Executar(listaDeArtistas);
            break;
        case 4:
            acessoMenu = new MenuAvaliarArtista();
            acessoMenu.Executar(listaDeArtistas);
            break;
        case 5:
            acessoMenu = new MenuExibirDetalhes();
            acessoMenu.Executar(listaDeArtistas);
            break;
        case 0:
            acessoMenu = new MenuFecharAplicacao();
            acessoMenu.Executar(listaDeArtistas);
            break;
        default:
            acessoMenu = new MenuExibirOpcaoInvalida(); 
            acessoMenu.Executar(listaDeArtistas);
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
    Console.Write($"\n{nomeArtista} foi registrado com sucesso!!!");
    Console.Write("Pressione qualquer tecla para voltar para o menu principal: ");
    Console.ReadKey();
}