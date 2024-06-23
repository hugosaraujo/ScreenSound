using ScreenSound.Modelos;

namespace ScreenSound.Interfaces;

internal interface IAvaliavel
{
    public double Media { get; }
    void AdicionarNota(Avaliacao nota); 
}
