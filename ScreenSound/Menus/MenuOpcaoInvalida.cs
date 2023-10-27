namespace ScreenSound.Menus;

internal class MenuOpcaoInvalida
{
    public void Executar()
    {
        Console.WriteLine("Opção Inválida!");
        Console.WriteLine("Pressione qualquer tecla para voltar para o Menu Principal... ");
        Console.ReadKey();
        Console.Clear();
    }
}
