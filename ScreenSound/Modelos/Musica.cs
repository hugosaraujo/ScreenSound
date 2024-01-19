namespace ScreenSound.Modelos;
using System.Reflection.Metadata.Ecma335;

internal class Musica
{
    //Implementação de material do curso 4, Linq, nessa classe. 
    public Musica(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Artista Artista { get; }
    public int Duracao { get; set; }
    public bool Disponibilidade { get; set; }
    
    public string DescricaoResumida => $"{Nome} pertence ao Artista {Artista.Nome}";
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if(Disponibilidade)
        {
            Console.WriteLine("Disponível para download");
        }
        else
        {
            Console.WriteLine("Não disponível para download");
        }
        Console.WriteLine();
    }
}

