using ScreenSound.Menus;
using ScreenSound.Modelos;

Banda braza = new Banda("Braza");
braza.AdicionarNota(new Avaliacao (5));
braza.AdicionarNota(new Avaliacao (9));
braza.AdicionarNota(new Avaliacao (8));
Banda vacations = new("Vacations");
vacations.AdicionarNota(new Avaliacao(10));
vacations.AdicionarNota(new Avaliacao(9));
vacations.AdicionarNota(new Avaliacao(10));

Dictionary<string, Banda> bandasRegistradas = new()
{
    { braza.Nome, braza },
    { vacations.Nome, vacations }
};

void ExibirBannerPrograma()
{
    string mensagemBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("Boas vindas ao Screen Sound");

}
void ExibeOpcoesMenu()
{
    ExibirBannerPrograma();
    Console.WriteLine();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar um álbum");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair do menu");

    Console.WriteLine();
    Console.Write("Digite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            MenuRegistrarBanda opcaoRegistrarBanda = new();
            opcaoRegistrarBanda.Executar(bandasRegistradas);
            ExibeOpcoesMenu();
            break;
        case 2:
            MenuRegistrarAlbuns opcaoRegistrarAlbum = new();
            opcaoRegistrarAlbum.Executar(bandasRegistradas);
            ExibeOpcoesMenu();
            break;
        case 3:
            MenuMostrarBandas opcaoMostraBandas = new();
            opcaoMostraBandas.Executar(bandasRegistradas);
            ExibeOpcoesMenu();
            break;
        case 4:
            MenuAvaliarBanda opcaoAvaliarBanda = new();
            opcaoAvaliarBanda.Executar(bandasRegistradas);
            ExibeOpcoesMenu();
            break;
        case 5:
            MenuExibirDetalhes opcaoExibirDetalhes = new();
            opcaoExibirDetalhes.Executar(bandasRegistradas);
            ExibeOpcoesMenu();
            break;
        case 0:
            MenuSair opcaoSair = new();
            opcaoSair.Executar();
            break;
        default:
            MenuOpcaoInvalida opcaoInvalida = new();
            opcaoInvalida.Executar();
            break;
    }
}

ExibeOpcoesMenu();