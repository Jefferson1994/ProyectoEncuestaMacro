using Azure;
using EcuenstasMacro.Neg.Catalogos;
using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using Microsoft.AspNetCore.Mvc;


namespace EcuestasMacro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public CatalogosController(ApiDbContext context) => _context = context;

        // GET: api/<CatalogosController>
        [HttpPost]
        [Route("api/Catalogos")]
        public IEnumerable<ResGetCatalogo> Get(ReqGetCatalogo raw)
        {
            try
            {
                var cara = new CatalogosNeg(_context).ObtenerCatalogos(raw);
                return cara;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("api/Preguntas")]
        public IEnumerable<ResGetPreguntas> GetPreguntas(ReqGetPreguntas raw)
        {
            try
            {
                var preguntas = new CatalogosNeg(_context).ObtenerPreguntas(raw);
                return preguntas;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
