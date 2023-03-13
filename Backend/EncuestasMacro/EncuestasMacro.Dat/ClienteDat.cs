

using EncuestasMacro.DTO;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EncuestasMacro.Dat
{
    public class ClienteDat
    {
        private readonly ApiDbContext _context;
        public ClienteDat(ApiDbContext context)
        {
            _context = context;
        }

        public static string cadenaConexion = "Data Source=PC01ASP11\\SQLEXPRESS;TrustServerCertificate=True;Initial Catalog=EncuestaMacro;Persist Security Info=True;User ID=sa;Password=admin";

        public DataTable ObtenerCliente(ReqGetCliente reqGetCliente)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_buscar_clientes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", reqGetCliente.Cedula);

                var resultQuery = cmd.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }


        }
    }
}
