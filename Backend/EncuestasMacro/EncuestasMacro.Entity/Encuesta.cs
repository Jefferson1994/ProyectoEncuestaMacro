
namespace EncuestasMacro.Entity
{
    internal class Encuesta
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public string respuesta { get; set; }  = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public Pregunta Pregunta { get; set; } = new Pregunta();
        public Sucursal Sucursal { get; set; } = new Sucursal();
        public Categoria Categoria { get; set; } = new Categoria();
    }
}
