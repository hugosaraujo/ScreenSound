using System.Net.Http.Headers;
using System.Threading.Channels;
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
            RegistroDeBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case 0:
            Console.WriteLine("Fechando o menu...");
            break;
        default:
            AvisarOpcaoInvalida();
            break;
    }
}

void RegistroDeBanda()
{
    Console.Clear();
    ExibirTituloOpcaoMenu("Resgitro de Banda");
    Console.Write("Digite o nome da banda que queira registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"{nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibeOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcaoMenu("Exibindo bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Nome: {banda}");
    }
    Console.Write("Pressione alguma tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibeOpcoesMenu();
}

void ExibirTituloOpcaoMenu(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras + 2, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine($"*{titulo}*");
    Console.WriteLine(asteriscos);
    Console.WriteLine();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcaoMenu("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write("Digite a nota da banda: ");
        Avaliacao notaDaBanda = Avaliacao.Parse(Console.ReadLine()!);
        banda.AdicionarNota((notaDaBanda));
        Console.WriteLine($"Registrando a nota {notaDaBanda.Nota}. A {nomeDaBanda} foi avaliado(a) com sucesso!");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"{nomeDaBanda} não foi encontrado(a)!");
        Console.Write("Pressione alguma tecla para voltar para o Menu...");
        Console.ReadKey();
        Console.Clear();
        ExibeOpcoesMenu();
    }
    Thread.Sleep(2000);
    Console.Clear();
    ExibeOpcoesMenu();
}
void AvisarOpcaoInvalida()
{
    Console.WriteLine("Opção Inválida!");
    Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal... ");
    Console.ReadKey();
    Console.Clear();
    ExibeOpcoesMenu();
}
void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloOpcaoMenu("Registrar Album");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda)) 
    {
        Console.Write("Digite o album que quer registrar: ");
        string nomeDoAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(banda, nomeDoAlbum));
        /**
         * Espaço para implementar a lógica de registrar um album
         *     */
        Console.WriteLine($"{nomeDoAlbum} da {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
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
    ExibeOpcoesMenu();
}
void ExibirDetalhes() { 
    Console.Clear();
    ExibirTituloOpcaoMenu("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que você quer saber os detalhes: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine();
        Console.WriteLine($"A média da banda {nomeDaBanda} é {banda.Media}");
        /**
         * Espaço reservado para completar função
         */
        Console.Write("Digite alguma tecla para voltar para o menu principal... ");
        Console.ReadKey();
        Console.Clear();
        ExibeOpcoesMenu();
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibeOpcoesMenu();
    }
}

ExibeOpcoesMenu();
