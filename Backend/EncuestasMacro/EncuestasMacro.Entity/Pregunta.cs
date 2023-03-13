
namespace EncuestasMacro.Entity
{
    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public string? PreguntaName { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
