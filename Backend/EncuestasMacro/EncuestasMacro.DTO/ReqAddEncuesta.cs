

namespace EncuestasMacro.DTO
{
    public class ReqAddEncuesta
    {
        public int IdPregunta { get; set; }
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public string Respuesta { get; set; } = string.Empty;

    }
}
