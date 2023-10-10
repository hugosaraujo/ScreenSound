using System.Net.Http.Headers;
using System.Threading.Channels;

Podcast pt = new Podcast("Bruno Gunter", "Podtrash");

Episodio psychoCop = new(684, "Psychocop", 62);
Episodio candyman = new(584, "Candyman", 73);

pt.AdicionarEpisodio(psychoCop);
pt.AdicionarEpisodio(candyman);

Episodio exorcista = new(666, "Exorcista", 140);
exorcista.AdicionarConvidados("Dalenogare");
exorcista.AdicionarConvidados("Lucas Maia");

pt.AdicionarEpisodio(exorcista);

Console.WriteLine(exorcista.Resumo);
Console.WriteLine(candyman.Resumo);

pt.ExibirDetalhes();
#region
//Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>(); 
//bandas.Add("Mastodon", new List<int> { 10, 9, 4});
//bandas.Add("Gojira", new List<int> { 8 });
//bandas.Add("Mac DeMarco", new());

//void ExibeBannerPrograma ()
//{
//    string mensagemBoasVindas = @"
//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//";
//    Console.WriteLine(mensagemBoasVindas);
//    Console.WriteLine("Boas vindas ao Screen Sound");

//}
//void ExibeOpcoesMenu()
//{
//    ExibeBannerPrograma();
//    Console.WriteLine();
//    Console.WriteLine("Digite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para mostrar todas as bandas");
//    Console.WriteLine("Digite 3 para avaliar uma banda");
//    Console.WriteLine("Digite 4 para exibir média da banda");
//    Console.WriteLine("Digite 0 para sair do menu");

//    Console.WriteLine();
//    Console.Write("Digite a sua opção: ");
//    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

//    switch(opcaoEscolhida)
//    {
//        case 1: RegistroDeBanda();
//            break;
//        case 2: MostrarBandasRegistradas();
//            break;
//        case 3: AvaliarBanda();
//            break;
//        case 4: ExibirMediaBanda();
//            break;
//        case 0: Console.WriteLine("Fechando o menu...");
//            break;
//        default: AvisoOpcaoInvalida();
//            break; 
//    }
//}

//void RegistroDeBanda()
//{
//    Console.Clear();
//    ExibeTituloOpcaoMenu("Resgitro de Banda");
//    Console.Write("Digite o nome da banda que queira registrar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    bandas.Add(nomeDaBanda, new List<int>());
//    Console.WriteLine($"{nomeDaBanda} foi registrado com sucesso!");
//    Thread.Sleep(2000);
//    Console.Clear();
//    ExibeOpcoesMenu();
//}

//void MostrarBandasRegistradas()
//{
//    Console.Clear();
//    ExibeTituloOpcaoMenu("Exibindo bandas registradas");
//    foreach (string banda in bandas.Keys)
//    {
//        Console.WriteLine($"Nome: {banda}");
//    }
//    Console.Write("Pressione alguma tecla para sair");
//    Console.ReadKey();
//    Console.Clear();
//    ExibeOpcoesMenu();
//}

//void ExibeTituloOpcaoMenu(string titulo)
//{
//    int quantidadeLetras = titulo.Length;
//    string asteriscos = string.Empty.PadLeft(quantidadeLetras+2, '*');
//    Console.WriteLine(asteriscos);
//    Console.WriteLine($"*{titulo}*");
//    Console.WriteLine(asteriscos);
//    Console.WriteLine();
//}   

//void AvaliarBanda()
//{
//    Console.Clear();
//    ExibeTituloOpcaoMenu("Avaliar Banda");
//    Console.Write("Digite o nome da banda que deseja avaliar: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandas.ContainsKey(nomeDaBanda))
//    {
//        Console.Write("Digite a nota da banda: ");
//        int notaDaBanda = int.Parse(Console.ReadLine()!);
//        bandas[nomeDaBanda].Add(notaDaBanda);
//        Console.WriteLine($"{nomeDaBanda} foi avaliado(a) com sucesso!");
//    }
//    else
//    {
//        Console.WriteLine();
//        Console.WriteLine($"{nomeDaBanda} não foi encontrado(a)!");
//        Console.Write("Pressione alguma tecla para voltar para o Menu...");
//        Console.ReadKey();
//        Console.Clear();
//        ExibeOpcoesMenu();
//    }
//    Thread.Sleep(2000);
//    Console.Clear();
//    ExibeOpcoesMenu();
//}       

//void ExibirMediaBanda()
//{
//    Console.Clear();
//    ExibeTituloOpcaoMenu("Exibir média da banda");
//    Console.Write("Digite o nome da banda que você quer saber a média: ");
//    string nomeDaBanda = Console.ReadLine()!;
//    if (bandas.ContainsKey(nomeDaBanda))
//    {
//        double media = bandas[nomeDaBanda].Average();
//        string mediaFormatada = media.ToString("N2");
//        Console.WriteLine($"A média da banda {nomeDaBanda} é {mediaFormatada}");
//        Thread.Sleep(3000);
//        Console.Clear();
//        ExibeOpcoesMenu();
//    }
//    else
//    {
//        Console.WriteLine();
//        Console.WriteLine("O nome dessa banda não está registrado no Screen Sound!");
//        Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal... ");
//        Console.ReadKey();
//        Console.Clear();
//        ExibeOpcoesMenu();
//    }
//}
//void AvisoOpcaoInvalida()
//{
//    Console.WriteLine("Opção Inválida!");
//    Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal... ");
//    Console.ReadKey();
//    Console.Clear();
//    ExibeOpcoesMenu();
//}

//ExibeOpcoesMenu();
#endregion