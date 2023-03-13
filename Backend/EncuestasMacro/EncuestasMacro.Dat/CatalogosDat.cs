
using EncuestasMacro.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EncuestasMacro.Dat
{
    public class CatalogosDat
    {

        private readonly IConfiguration _configuracion;
        public CatalogosDat(IConfiguration configuration) => _configuracion = configuration;

        public DataTable ObtenerCatalogos(ReqGetCatalogo reqGetCatalogo)
        {
            SqlConnection conexion = new SqlConnection(_configuracion.GetConnectionString("ConnectionStrings"));

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


            
            SqlConnection conexion = new SqlConnection(_configuracion.GetConnectionString("ConnectionStrings"));

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
