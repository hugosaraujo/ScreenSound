class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponibilidade { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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

