//dotnet add package Microsoft.Data.SqlClient
//dotnet add package Dapper
//dotnet add package Microsoft.AspNetCore.Session
//dotnet add package NewtonSoft.Json
using Microsoft.Data.SqlClient;
using Dapper;

namespace TP02.Models;

public static class BD
{
    public int Login(string email, string contraseña)
    {

    }

    public DatoPersonal GetUsuario(int id)
    {

    }

    public List<DatoFamiliar> GetDatosFamiliares(int id)
    {

    }

    public List<DatosInteres> GetDatosInteres(int id)
    {

    }

}