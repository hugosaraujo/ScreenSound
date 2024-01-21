using ScreenSound.BancoDeDados;
using ScreenSound.Menus;
using ScreenSound.Modelos;
using System.Net.NetworkInformation;

try
{
    var artistaDal = new ArtistaDAL();
    artistaDal.Deletar(new Artista()
    {
        Id = 3002,
    });

    var listaDeArtistas = artistaDal.Listar();

    foreach (var artista in listaDeArtistas)
    {
        Console.WriteLine(artista);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

return;

Artista braza = new("Braza", "Banda Braza");
braza.AdicionarNota(new Avaliacao(5));
braza.AdicionarNota(new Avaliacao(9));
braza.AdicionarNota(new Avaliacao(8));
Artista vacations = new("Vacations", "Banda Vacations");
vacations.AdicionarNota(new Avaliacao(10));
vacations.AdicionarNota(new Avaliacao(9));
vacations.AdicionarNota(new Avaliacao(10));

Dictionary<string, Artista> artistasRegistrados = new()
{
    { braza.Nome, braza },
    { vacations.Nome, vacations }
};

Dictionary<int, Menu> opcoesMenu = new();
opcoesMenu.Add(1, new MenuRegistrarArtista());
opcoesMenu.Add(2, new MenuRegistrarAlbuns());
opcoesMenu.Add(3, new MenuRegistrarMusica());
opcoesMenu.Add(4, new MenuMostrarArtistas());
opcoesMenu.Add(5, new MenuMostrarMusicas());
opcoesMenu.Add(6, new MenuAvaliarArtista());
opcoesMenu.Add(7, new MenuAvaliarAlbum());
opcoesMenu.Add(8, new MenuExibirDetalhes());
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
    Console.WriteLine("Digite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar um álbum");
    Console.WriteLine("Digite 3 para registrar musica");
    Console.WriteLine("Digite 4 para mostrar todos artistas");
    Console.WriteLine("Digite 5 para mostrar musicas");
    Console.WriteLine("Digite 6 para avaliar um artista");
    Console.WriteLine("Digite 7 para avaliar um album");
    Console.WriteLine("Digite 8 para exibir os detalhes de um artista");
    Console.WriteLine("Digite 0 para sair do menu");

    Console.WriteLine();
    Console.Write("Digite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if (opcoesMenu.ContainsKey(opcaoEscolhida))
    {
        Menu MenuExibicao = opcoesMenu[opcaoEscolhida];
        MenuExibicao.Executar(artistasRegistrados);
        if (opcaoEscolhida > 0) ExibeOpcoesMenu();
    }
    else
    {
        Menu mensagemErro = new();
        mensagemErro.OpcaoInvalida();
        ExibeOpcoesMenu();
    }
}

ExibeOpcoesMenu();