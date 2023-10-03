using System.Threading.Channels;

List<string> listaDeBandas = new List<string> {"Men at Work", "Kali Uchis"};  

void ExibeBannerPrograma ()
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
    ExibeBannerPrograma();
    Console.WriteLine();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média da banda");
    Console.WriteLine("Digite 0 para sair do menu");

    Console.WriteLine();
    Console.Write("Digite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch(opcaoEscolhida)
    {
        case 1: RegistroDeBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Opção 3 Escolhida...");
            break;
        case 4: Console.WriteLine("Opção 4 Escolhida...");
            break;
        case 0: Console.WriteLine("Fechando o menu...");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break; 
    }
}

void RegistroDeBanda()
{
    Console.Clear();
    ExibeTituloOpcaoMenu("Resgitro de Banda");
    Console.Write("Digite o nome da banda que queira registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"{nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibeOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibeTituloOpcaoMenu("Exibindo bandas registradas");
    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine($"Nome: {banda}");
    }
    Console.Write("Pressione alguma tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibeOpcoesMenu();
}

void ExibeTituloOpcaoMenu(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras+2, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine($"*{titulo}*");
    Console.WriteLine(asteriscos);
    Console.WriteLine();
}   

ExibeOpcoesMenu();