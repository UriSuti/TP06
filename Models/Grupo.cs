namespace TP02.Models;

public static class Grupo
{
    public static Dictionary<int, Integrante> integrantes { get; private set; }

    public static void inicializarGrupo()
    {
        integrantes = new Dictionary<int, Integrante>();

        List<DatoFamiliar> datoFamiliar1 = new List<DatoFamiliar>();
        datoFamiliar1.Add(new DatoFamiliar("Esteban", "Suti", "Padre", "1.70; Trabaja en Globant"));
        datoFamiliar1.Add(new DatoFamiliar("Dana", "Kohan", "Madre", "1.58; Trabaja en Hospital Italiano"));
        integrantes.Add(49194950, new Integrante(49194950, new DatoPersonal("Uriel", "Suti", DateTime.Parse("2009/02/09")), datoFamiliar1, new DatosInteres("Jugar a la Play", "Breaking Bad", "Alan Vitas", "Todas las materias de Info")));

        List<DatoFamiliar> datoFamiliar2 = new List<DatoFamiliar>();
        datoFamiliar2.Add(new DatoFamiliar("Hernán", "Vitas", "Padre", "1.75; Trabaja en Tienda Zoom"));
        datoFamiliar2.Add(new DatoFamiliar("Romina", "Bursztyn", "Madre", "1.50; Trabaja en Tienda Zoom"));
        integrantes.Add(49319580, new Integrante(49319580, new DatoPersonal("Alan", "Vitas", DateTime.Parse("2009/02/27")), datoFamiliar2, new DatosInteres("Jugar al Fútbol", "Breaking Bad", "Uriel Suti", "Todas las materias de Info y Matemática")));
    }
}