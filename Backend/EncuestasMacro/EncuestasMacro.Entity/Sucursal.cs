

namespace EncuestasMacro.Entity
{
    internal class Sucursal
    {
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; } = string.Empty;
        public Canton Canton { get; set; } = new Canton();
    }
}
