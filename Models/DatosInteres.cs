namespace TP02.Models;

public class DatosInteres
{
    public int id { get; private set; }
    public int idUsuario { get; private set; }
    public int tipoInteres { get; private set; } // 1: Hobby, 2: Serie, 3: Amigo, 4: Gusto
    public string interes { get; private set; }

    public DatosInteres(int idUsuario, int tipoInteres, string interes)
    {
        this.idUsuario = idUsuario;
        this.tipoInteres = tipoInteres;
        this.interes = interes;
    }
}