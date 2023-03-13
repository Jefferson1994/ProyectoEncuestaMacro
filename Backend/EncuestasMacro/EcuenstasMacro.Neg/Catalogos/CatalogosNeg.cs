

using EncuestasMacro.Dat;
using EncuestasMacro.DTO;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EcuenstasMacro.Neg.Catalogos
{
    public class CatalogosNeg
    {
        private readonly IConfiguration _configuracion;
        public CatalogosNeg(IConfiguration configuration) => _configuracion = configuration;

        public List<ResGetCatalogo> ObtenerCatalogos(ReqGetCatalogo reqGetCatalogo)
        {
            DataTable dt = new CatalogosDat(_configuracion).ObtenerCatalogos(reqGetCatalogo);

            var resGetCatalogos = (from rw in dt.AsEnumerable()
                                   select new ResGetCatalogo()
                                   {
                                       Codigo = Convert.ToInt32(rw["Codigo"]),
                                       Descripcion = rw["Descripcion"]?.ToString()
                                   }).ToList();

            return resGetCatalogos;
        }
        public List<ResGetPreguntas> ObtenerPreguntas(ReqGetPreguntas reqGetPreguntas)
        {
            DataTable dt = new CatalogosDat(_configuracion).ObtenerPreguntas(reqGetPreguntas);

            var resGetPreguntas = (from rw in dt.AsEnumerable()
                                   select new ResGetPreguntas()
                                   {
                                       IdPregunta = Convert.ToInt32(rw["IdPregunta"]),
                                       Pregunta= rw["Pregunta"]?.ToString(),
                                       IdCategoria = Convert.ToInt32(rw["IdCategoria"]),
                                       Categoria = rw["Categoria"]?.ToString(),
                                       ValorInicial = rw["ValorInicial"]?.ToString(),
                                       ValorFinal  = rw["ValorFinal"]?.ToString()
                                   }).ToList();

            return resGetPreguntas;
        }
    }
}
