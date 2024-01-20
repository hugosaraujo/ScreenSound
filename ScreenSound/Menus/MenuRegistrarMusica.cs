using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarMusica:Menu
    {
        internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
        {
            base.Executar(artistasRegistrados);
            ExibirTituloOpcaoMenu("Registrar Música");
            Console.Write("Digite o nome do artista: ");
            string nomeArtista = Console.ReadLine()!;
            if (artistasRegistrados.ContainsKey(nomeArtista))
            {
                Console.Write("Digite o nome da música que quer registrar: ");
                string tituloMusica = Console.ReadLine()!;
                Artista artista = artistasRegistrados[nomeArtista];
                artista.AdicionarMusica(new Musica(artista, tituloMusica));
                Console.WriteLine($"{tituloMusica} de {nomeArtista} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{nomeArtista} não foi encontrada!");
                Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
