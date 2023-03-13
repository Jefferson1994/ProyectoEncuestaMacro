

using EncuestasMacro.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EncuestasMacro.Dat
{
    public class EncuestaDat
    {
        private readonly IConfiguration _configuracion;
        public EncuestaDat(IConfiguration configuration) => _configuracion = configuration;

        public DataTable ObtenerCliente(ReqAddEncuesta reqAddEncuesta)
        {
            SqlConnection conexion = new SqlConnection(_configuracion.GetConnectionString("ConnectionStrings"));

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_registrar_encuesta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@id_pregunta", reqAddEncuesta.IdPregunta, SqlDbType.VarChar );
                cmd.Parameters.AddWithValue("@id_cliente", reqAddEncuesta.IdCliente);
                cmd.Parameters.AddWithValue("@id_sucursal", reqAddEncuesta.IdSucursal);
                cmd.Parameters.AddWithValue("@respuesta", reqAddEncuesta.Respuesta);

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
