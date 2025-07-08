namespace TP02.Models;

public class DatosInteres
{
    public string hobbies { get; private set; }
    public string seriesFavoritas { get; private set; }
    public string amigos { get; private set; }
    public string gustosEscolares { get; private set; }

    public DatosInteres(string hobbies, string seriesFavoritas, string amigos, string gustosEscolares)
    {
        this.hobbies = hobbies;
        this.seriesFavoritas = seriesFavoritas;
        this.amigos = amigos;
        this.gustosEscolares = gustosEscolares;
    }
}