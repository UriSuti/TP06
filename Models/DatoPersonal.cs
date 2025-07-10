namespace TP02.Models;

public class DatoPersonal
{
    public int id { get; private set; }
    public string nombre { get; private set; }
    public string apellido { get; private set; }
    public string email { get; private set; }
    public string contraseña { get; private set; }
    public DateTime fechaNacimiento { get; private set; }
    public string foto { get; private set; }

    public DatoPersonal(int id, string nombre, string apellido, string email, string contraseña, DateTime fechaNacimiento, string foto)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
    }

    public int obtenerEdad()
    {
        int edad = DateTime.Now.Year - fechaNacimiento.Year;

        if (DateTime.Now.Month < fechaNacimiento.Month || DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day)
        {
            edad--;
        }

        return edad;
    }
}