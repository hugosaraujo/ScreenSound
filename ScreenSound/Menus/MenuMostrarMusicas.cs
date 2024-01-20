using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuMostrarMusicas : Menu    
    {
        internal override void Executar(Dictionary<string, Artista> artistasRegistrados)
        {
            base.Executar(artistasRegistrados);
            ExibirTituloOpcaoMenu("Mostrar Músicas");
            Console.Write("Digite o nome do artista: ");
            string nomeArtista = Console.ReadLine()!;
            if (artistasRegistrados.ContainsKey(nomeArtista))
            {
                Artista artista = artistasRegistrados[nomeArtista];
                artista.ExibirMusicas();
                Console.WriteLine("Digite qualquer tecla para voltar para o menu principal");
                Console.ReadKey();
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
