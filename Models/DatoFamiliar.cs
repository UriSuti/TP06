namespace TP02.Models;

public class DatoFamiliar
{
    public int id { get; private set; }
    public int idUsuario { get; private set; }
    public string nombre { get; private set; }
    public string apellido { get; private set; }
    public string parentesco { get; private set; }
    public string descripcion { get; private set; }

    public DatoFamiliar(string nombre, string apellido, string parentesco, string descripcion)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.parentesco = parentesco;
        this.descripcion = descripcion;
    }
}