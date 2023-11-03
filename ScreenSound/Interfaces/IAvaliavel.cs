using ScreenSound.Modelos;

namespace ScreenSound.Interfaces;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    public double Media { get; }
}
