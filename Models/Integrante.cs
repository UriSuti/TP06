namespace TP02.Models;

public class Integrante
{
    public int dni { get; private set; }
    public DatoPersonal datosPersonales { get; private set; }
    public List<DatoFamiliar> datosFamiliares { get; private set; }
    public DatosInteres datosIntereses { get; private set; }

    public Integrante(int dni, DatoPersonal datosPersonales, List<DatoFamiliar> datoFamiliares, DatosInteres datosInteres)
    {
        this.dni = dni;
        this.datosPersonales = datosPersonales;
        this.datosFamiliares = datoFamiliares;
        this.datosIntereses = datosInteres;
    }
}