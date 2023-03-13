
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

        public ResAddEncuesta AgregarEncuesta(ReqAddEncuesta reqAddEncuesta)
        {
            SqlConnection conexion = new SqlConnection(_configuracion.GetConnectionString("ConnectionStrings"));
            ResAddEncuesta resAddEncuesta = new();
            try
            {

                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_registrar_encuesta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_pregunta", SqlDbType.Int, reqAddEncuesta.IdPregunta);
                cmd.Parameters.Add("@id_cliente", SqlDbType.Int, reqAddEncuesta.IdCliente);
                cmd.Parameters.Add("@id_sucursal", SqlDbType.Int, reqAddEncuesta.IdSucursal);
                cmd.Parameters.Add("@respuesta", SqlDbType.VarChar, 300, reqAddEncuesta.Respuesta);
                cmd.Parameters.Add("@o_mensaje", SqlDbType.VarChar, 300, resAddEncuesta.o_mensaje).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@o_codigo", SqlDbType.Int, resAddEncuesta.o_codigo).Direction = ParameterDirection.Output;

                var resultQuery = cmd.ExecuteNonQuery();
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return resAddEncuesta;

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
