using Azure;
using EcuenstasMacro.Neg.Catalogos;
using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using Microsoft.AspNetCore.Mvc;


namespace EcuestasMacro.Controllers
{
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly IConfiguration _configuracion;
        public CatalogosController(IConfiguration configuration) => _configuracion = configuration;

        // GET: api/<CatalogosController>
        [HttpPost]
        [Route("api/Catalogos")]
        public IEnumerable<ResGetCatalogo> Get(ReqGetCatalogo raw)
        {
            try
            {
                var cara = new CatalogosNeg(_configuracion).ObtenerCatalogos(raw);
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
                var preguntas = new CatalogosNeg(_configuracion).ObtenerPreguntas(raw);
                return preguntas;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
