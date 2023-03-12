using EncuestasMacro.DTO;
using Microsoft.EntityFrameworkCore;


namespace EncuestasMacro.Dat
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            :base (options)
        {

        }
        public DbSet<ResGetCatalogo> resGetCatalogos {  get; set; }

    }
}
