namespace WebApplication1.ADO.NET.DAL.Repositories;
using Microsoft.Data.SqlClient;
public class SqlConnection()
{
    private string servidor;
    private string baseDatos;

    public ConexionBD(string servidor, string baseDatos)
    {
        this.servidor = servidor;
        this.baseDatos = baseDatos;
    }

    public SqlConnection ObtenerConexion()
    {
        string cadenaConexion =
            $"Server={servidor};Database={baseDatos};Trusted_Connection=True;TrustServerCertificate=True;";

        SqlConnection conexion = new SqlConnection(cadenaConexion);

        conexion.Open();

        return conexion;
    }
}

