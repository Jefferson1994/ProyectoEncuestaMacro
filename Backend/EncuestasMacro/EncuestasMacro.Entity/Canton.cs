
namespace EncuestasMacro.Entity
{
    internal class Canton
    {
        public int IdCanton { get; set; }
        public string NombreCanton { get; set; } = string.Empty;
        public Provincia Provincia { get; set;} = new Provincia();
    }
}
