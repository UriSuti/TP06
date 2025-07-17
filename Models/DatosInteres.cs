namespace TP02.Models;

public class DatosInteres
{
    public int Id { get; private set; }
    public int IdUsuario { get; private set; }
    public int TipoInteres { get; private set; } // 1: Hobby, 2: Serie, 3: Amigo, 4: Gusto
    public string Interes { get; private set; }

    public DatosInteres(int Id, int IdUsuario, int TipoInteres, string Interes)
    {
        this.Id = Id;
        this.IdUsuario = IdUsuario;
        this.TipoInteres = TipoInteres;
        this.Interes = Interes;
    }
    public DatosInteres()
    {
        
    }
}