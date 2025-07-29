namespace TP02.Models;

public class DatoPersonal
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public string Email { get; private set; }
    public string Contraseña { get; private set; }
    public DateTime FechaNacimiento { get; private set; }
    public string Foto { get; private set; }

    public DatoPersonal(int Id, string Nombre, string Apellido, string Email, string Contraseña, DateTime FechaNacimiento, string Foto)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.FechaNacimiento = FechaNacimiento;
    }
    public int obtenerEdad()
    {
        int edad = DateTime.Now.Year - FechaNacimiento.Year;

        if (DateTime.Now.Month < FechaNacimiento.Month || DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day)
        {
            edad--;
        }

        return edad;
    }
}