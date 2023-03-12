
namespace EncuestasMacro.Entity
{
    internal class Escala
    {
        public int IdEscala { get; set; }
        public string ValorInicial { get; set; } = String.Empty;
        public string ValorFinal { get; set; } = String.Empty;
        public Categoria Tipo { get; set; } = new Categoria();
    }
}
