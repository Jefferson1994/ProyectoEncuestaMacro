
namespace EncuestasMacro.DTO
{
    public class ResGetPreguntas
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; } = string.Empty;
        public int IdCategoria { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string ValorInicial { get; set; } = string.Empty;
        public string ValorFinal { get; set; } = string.Empty;
    }
}
