using ScreenSound.Modelos;

namespace ScreenSound.Menu;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Artista> listaDeArtistas)
    {
        base.Executar(listaDeArtistas);
        ExibirTitulo("Registro de álbuns");
        Console.Write("Digite o artista cujo álbum deseja registrar: ");
        string nomeArtista = Console.ReadLine()!;

        if (listaDeArtistas.ContainsKey(nomeArtista))
        {
            Artista artista = listaDeArtistas[nomeArtista];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            artista.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeArtista} foi registrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Artista não encontrado no sistema");
        }
        Console.Write("\nPressione qualquer tecla para voltar para o Menu Principal: ");
        Console.ReadKey();
    }
}
