

using EncuestasMacro.Dat;
using EncuestasMacro.DTO;

namespace EcuenstasMacro.Neg.Catalogos
{
    public class CatalogosNeg
    {
        private readonly ApiDbContext _context;
        public CatalogosNeg(ApiDbContext context)
        {
            _context = context;
        }

        public List<ResGetCatalogo> ObtenerCatalogos(ReqGetCatalogo reqGetCatalogo)
        {
            var catalogosDat = new CatalogosDat(_context).ObtenerCatalogos(reqGetCatalogo);
            return catalogosDat;
        }
    }
}
