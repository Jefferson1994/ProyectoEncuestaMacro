
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

        public static string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=EncuenstaMacro;Trusted_Connection=True; Data Source=.;User ID=sa;";

        public List<ResGetCatalogo> ObtenerCatalogos(ReqGetCatalogo reqGetCatalogo)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar_catalogos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", reqGetCatalogo.codigo);
                cmd.Parameters.AddWithValue("@tipo", reqGetCatalogo.tipo);
                
                var resultQuery = cmd.ExecuteNonQuery();
                return null;

            }
            catch (Exception)
            {
                throw;
            } 
            finally 
            { 
                conexion.Close(); 
            }

            //try
            //{
            //    List<SqlParameter> parms = new List<SqlParameter>
            //    {
            //        // Create parameter(s)    
            //        new SqlParameter { ParameterName = "@codigo", Value = reqGetCatalogo.codigo },
            //        new SqlParameter { ParameterName = "@tipo", Value = reqGetCatalogo.tipo }
            //    };

            //    var res = _context.resGetCatalogos.FromSqlRaw("sp_listar_catalogos").ToList();
            //    return res;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
    }
}
