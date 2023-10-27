using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda:Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
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
    }
}
