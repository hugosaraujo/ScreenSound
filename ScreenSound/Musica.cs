class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponibilidade;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao} segundos");
        if(disponibilidade)
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

