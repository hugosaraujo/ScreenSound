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

Dictionary<int, Menu> opcoesMenu = new();
opcoesMenu.Add(1, new MenuRegistrarBanda());
opcoesMenu.Add(2, new MenuRegistrarAlbuns());
opcoesMenu.Add(3, new MenuMostrarBandas());
opcoesMenu.Add(4, new MenuAvaliarBanda());
opcoesMenu.Add(5, new MenuAvaliarAlbum());
opcoesMenu.Add(6, new MenuExibirDetalhes());
opcoesMenu.Add(0, new MenuSair());


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
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair do menu");

    Console.WriteLine();
    Console.Write("Digite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if(opcoesMenu.ContainsKey(opcaoEscolhida))
    {
        Menu MenuExibicao = opcoesMenu[opcaoEscolhida];
        MenuExibicao.Executar(bandasRegistradas);
        if(opcaoEscolhida > 0) ExibeOpcoesMenu();
    }
    else
    {
        Menu mensagemErro = new();
        mensagemErro.OpcaoInvalida();
        ExibeOpcoesMenu();
    }
}

ExibeOpcoesMenu();