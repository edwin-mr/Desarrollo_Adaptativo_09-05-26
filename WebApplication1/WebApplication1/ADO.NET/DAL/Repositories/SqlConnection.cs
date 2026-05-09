namespace WebApplication1.ADO.NET.DAL.Repositories;
using Microsoft.Data.SqlClient;
public class SqlConnection()
{
    private string cadenaConexion =
        "Server=TU_SERVIDOR;Database=TU_BASE;Trusted_Connection=True;TrustServerCertificate=True;";

    public SqlConnection ObtenerConexion()
    {
        SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();

        return conexion;
    }
}

