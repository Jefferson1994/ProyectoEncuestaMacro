
using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using EncuestasMacro.Entity;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text.Json;

namespace EcuenstasMacro.Neg.Encuesta
{
    public class EncuestaNeg
    {
        private readonly IConfiguration _configuracion;
        public EncuestaNeg(IConfiguration configuration) => _configuracion = configuration;
        public ResAddEncuesta AgregarEncuesta(ReqAddEncuesta reqAddEncuesta)
        {
            var dt = new EncuestaDat(_configuracion).AgregarEncuesta(reqAddEncuesta);

            return null;
        }

    }
}
