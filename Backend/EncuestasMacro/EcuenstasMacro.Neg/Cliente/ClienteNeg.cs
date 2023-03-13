

using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using EncuestasMacro.Entity;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text.Json;

namespace EcuenstasMacro.Neg.ClienteNeg
{
    public class ClienteNeg
    {
        private readonly IConfiguration _configuracion;
        public ClienteNeg(IConfiguration configuration) => _configuracion = configuration;

        public ResGetCliente ObtenerCliente(ReqGetCliente reqGetCliente)
        {
            DataTable dt = new ClienteDat(_configuracion).ObtenerCliente(reqGetCliente);
            ResGetCliente resGetCliente = new();

            if(dt.Rows.Count > 0)
            {
                var data = dt.Rows.OfType<DataRow>()
                          .Select(row => dt.Columns.OfType<DataColumn>()
                              .ToDictionary(col => col.ColumnName, c => row[c])).ToList();
                resGetCliente.Cliente = JsonSerializer.Deserialize<Cliente?>(JsonSerializer.Serialize(data[0]));
            }

            return resGetCliente;
        }
    }
}
