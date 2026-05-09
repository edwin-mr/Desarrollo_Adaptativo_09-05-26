namespace WebApplication1.ADO.NET.DAL.Repositories;
using Microsoft.Data.SqlClient;
using System;

public class SqlCommand
{
    private ConexionBD conexionBD = new ConexionBD();

    public void ObtenerProductos()
    {
        using (SqlConnection conexion = conexionBD.ObtenerConexion())
        {
            string query = "SELECT * FROM Productos";

            SqlCommand cmd = new SqlCommand(query, conexion);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    $"ID: {reader["Id"]} | Nombre: {reader["Nombre"]}"
                );
            }

            reader.Close();
        }
    }
}