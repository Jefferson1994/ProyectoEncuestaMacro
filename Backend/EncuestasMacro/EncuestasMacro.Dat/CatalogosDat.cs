
using EncuestasMacro.DTO;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace EncuestasMacro.Dat
{
    public class CatalogosDat
    {

        private readonly ApiDbContext _context;
        public CatalogosDat(ApiDbContext context)
        {
            _context = context;
        }

        public static string cadenaConexion = "Data Source=PC01ASP11\\SQLEXPRESS;Initial Catalog=EncuestaMacro;Persist Security Info=True;User ID=sa;Password=admin";

        public DataTable ObtenerCatalogos(ReqGetCatalogo reqGetCatalogo)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar_catalogo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", reqGetCatalogo.codigo);
                cmd.Parameters.AddWithValue("@tipo", reqGetCatalogo.tipo);
                
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

        public DataTable ObtenerPreguntas(ReqGetPreguntas reqGetPreguntas)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar_preguntas", conexion);
                cmd.Parameters.AddWithValue("@codigo", reqGetPreguntas.codigo);
                cmd.CommandType = CommandType.StoredProcedure;

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
