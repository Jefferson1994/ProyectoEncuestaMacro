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
                //var cliente = new ClienteNeg(_context).ObtenerCliente(raw);
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
