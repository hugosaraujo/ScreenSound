class Episodio
{
    List<string> convidados = new List<string>();
    public Episodio(int ordem, string titulo)
    {
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo 
    {
        get
        {
            return $"{Ordem} - {Titulo} com {string.Join(", ", convidados)}";
        }
    }
    public string Titulo { get; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);        
    }
}