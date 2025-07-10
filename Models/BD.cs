//dotnet add package Microsoft.Data.SqlClient
//dotnet add package Dapper
//dotnet add package Microsoft.AspNetCore.Session
//dotnet add package NewtonSoft.Json
using Microsoft.Data.SqlClient;
using Dapper;

namespace TP02.Models;

public static class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=NombreBase;Integrated Security=True;TrustServerCertificate=True;";
    public int Login(string email, string contraseña)
    {
        int id = -1;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id FROM DatoPersonal WHERE Email = @pEmail AND Contraseña = @pContraseña";
            id = connection.QueryFirstOrDefault<int>(query, new { pEmail = email, pContraseña = contraseña});
        }
        return id;
    }

    public DatoPersonal GetUsuario(int id)
    {
        DatoPersonal usuarioBuscar = null;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatoPersonal WHERE Id = @pId";
            usuarioBuscar = connection.QueryFirstOrDefault<DatoPersonal>(query, new { pId = id });
        }
        return usuarioBuscar;
    }

    public List<DatoFamiliar> GetDatosFamiliares(int id)
    {
        List<DatoFamiliar> datosFamiliares = new List<DatoFamiliar>();
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatoFamiliar WHERE IdUsuario = @pId";
            datosFamiliares = connection.Query<DatoFamiliar>(query).ToList();
        }
        return datosFamiliares;
    }

    public List<DatosInteres> GetDatosInteres(int id)
    {
        List<DatosInteres> datosInteres = new List<DatosInteres>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatosInteres WHERE IdUsuario = @pId";
            datosInteres = connection.Query<DatosInteres>(query).ToList();
        }
        return datosInteres;
    }

}