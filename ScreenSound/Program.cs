int opcaoEscolhida = -1;

List<string> listaDeArtistas = new List<string>();

while (opcaoEscolhida != 0)
{
    exibirMenuDeOpcoes();
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

void exibirMenuDeOpcoes()
{
    exibirBanner();

    Console.WriteLine("Digite 1 para registrar uma banda ou artista");
    Console.WriteLine("Digite 2 para mostrar artistas registrados");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da banda");
    Console.WriteLine("Digite 0 para fechar a aplicação");

    Console.Write("Selecione uma da opções disponíveis: ");
    opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch(opcaoEscolhida)
    {
        case 1: 
            registrarBanda();
            break;
        case 2:
            exibirMensagemDaOpcaoSelecionada(opcaoEscolhida);
            break;
        case 3:
            exibirMensagemDaOpcaoSelecionada(opcaoEscolhida);
            break;
        case 4:
            exibirMensagemDaOpcaoSelecionada(opcaoEscolhida);
            break;
        case 0:
            exibirMensagemDaOpcaoSelecionada(opcaoEscolhida);
            Console.WriteLine("Encerrando a aplicação!!!");
            break;
        default: Console.WriteLine("Você selecionou uma opção inválida");
            break;
    }
}

void exibirMensagemDaOpcaoSelecionada(int opcao)
{
    Console.WriteLine($"Você selecionou a opção {opcao}");
}

void registrarBanda()
{
    Console.Clear();
    exibirMensagemDaOpcaoSelecionada(opcaoEscolhida);
    Console.Write("Digite do nome do Artista: ");
    string artista = Console.ReadLine()!;
    listaDeArtistas.Add(artista);
    Console.WriteLine($"{artista} registrado com sucesso!!!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirMenuDeOpcoes();
}