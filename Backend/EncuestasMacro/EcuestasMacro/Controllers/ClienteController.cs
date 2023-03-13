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
        private readonly ApiDbContext _context;
        public ClienteController(ApiDbContext context) => _context = context;

        // GET: api/<CatalogosController>
        [HttpPost]
        public ResGetCliente Get(ReqGetCliente raw)
        {
            try
            {
                var cliente = new ClienteNeg(_context).ObtenerCliente(raw);
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
