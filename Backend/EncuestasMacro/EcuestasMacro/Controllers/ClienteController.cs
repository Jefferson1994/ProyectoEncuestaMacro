using EcuenstasMacro.Neg.ClienteNeg;
using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EcuestasMacro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IConfiguration _configuracion;
        public ClienteController(IConfiguration configuration) => _configuracion = configuration;

        // GET: api/<CatalogosController>
        [HttpPost]
        public ResGetCliente Get(ReqGetCliente raw)
        {
            try
            {
                var cliente = new ClienteNeg(_configuracion).ObtenerCliente(raw);
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
