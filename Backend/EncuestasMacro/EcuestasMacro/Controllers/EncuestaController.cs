using EcuenstasMacro.Neg.Encuesta;
using EncuestasMacro.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EcuestasMacro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncuestaController : ControllerBase
    {
        private readonly IConfiguration _configuracion;
        public EncuestaController(IConfiguration configuration) => _configuracion = configuration;

        // GET: api/<EncuestaController>
        [HttpPost]
        public ResAddEncuesta Get(ReqAddEncuesta raw)
        {
            try
            {
                var encuesta = new EncuestaNeg(_configuracion).AgregarEncuesta(raw);
                return encuesta;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
