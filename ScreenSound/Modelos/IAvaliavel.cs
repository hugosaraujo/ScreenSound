namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    public double Media { get; }
}
