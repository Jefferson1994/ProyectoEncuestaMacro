using EcuenstasMacro.Neg.ClienteNeg;
using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EcuestasMacro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncuestaController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public EncuestaController(ApiDbContext context) => _context = context;

        // GET: api/<EncuestaController>
        [HttpPost]
        public ResGetCliente Get(ReqAddEncuesta raw)
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
