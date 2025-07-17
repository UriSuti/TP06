//dotnet add package Microsoft.Data.SqlClient
//dotnet add package Dapper
//dotnet add package Microsoft.AspNetCore.Session
//dotnet add package NewtonSoft.Json
using Microsoft.Data.SqlClient;
using Dapper;

namespace TP02.Models;

public static class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=TP06;Integrated Security=True;TrustServerCertificate=True;";
    public static int Login(string email, string contraseña)
    {
        int id = -1;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Id FROM DatoPersonal WHERE Email = @pEmail AND Contraseña = @pContraseña";
            id = connection.QueryFirstOrDefault<int>(query, new { pEmail = email, pContraseña = contraseña});
        }
        return id;
    }

    public static DatoPersonal GetUsuario(int id)
    {
        DatoPersonal usuarioBuscar = null;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatoPersonal WHERE Id = @pId";
            usuarioBuscar = connection.QueryFirstOrDefault<DatoPersonal>(query, new { pId = id });
        }
        return usuarioBuscar;
    }

    public static List<DatoFamiliar> GetDatosFamiliares(int id)
    {
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatoFamiliar WHERE IdUsuario = @pId";
            return connection.Query<DatoFamiliar>(query, new { pId = id }).ToList();
        }
    }

    public static List<DatosInteres> GetDatosInteres(int id)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatosInteres WHERE IdUsuario = @pId";
            return connection.Query<DatosInteres>(query, new { pId = id }).ToList();
        }
    }
}