class Episodio
{
public Episodio(int ordem, string titulo)
    {
        Ordem = ordem;
        Titulo = titulo;       
    }

    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo => $"Episódio {Ordem} - {Titulo}";
    public string Titulo { get; }

    public void AdicionarConvidados()
    {

    }
}