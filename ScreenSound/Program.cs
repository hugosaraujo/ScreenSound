using ScreenSound.Menu;
using ScreenSound.Modelos;

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

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarArtista());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuExibirArtistas());
opcoes.Add(4, new MenuAvaliarArtista());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(0, new MenuFecharAplicacao());

ExibirMenuDeOpcoes();

void ExibirMenuDeOpcoes()
{
    Console.Clear();

    Menu.ExibirBanner();

    Console.WriteLine("Digite 1 para registrar uma banda ou artista");
    Console.WriteLine("Digite 2 para registrar um album de um artista");
    Console.WriteLine("Digite 3 para mostrar artistas registrados");
    Console.WriteLine("Digite 4 para avaliar um artita");
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes de um artista");
    Console.WriteLine("Digite 0 para fechar a aplicação\n");

    Console.Write("Selecione uma da opções disponíveis: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu acessoOpcoes = opcoes[opcaoEscolhida];
        acessoOpcoes.Executar(listaDeArtistas);
        
        if(opcaoEscolhida !=0 ) ExibirMenuDeOpcoes();
    }
    else
    {
        Console.Write("\nPressione qualquer tecla para voltar para o Menu Principal!");
        Thread.Sleep(2000);
    }
}