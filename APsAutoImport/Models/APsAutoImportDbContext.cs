using Microsoft.EntityFrameworkCore;

namespace APsAutoImport.Models
{
    public class APsAutoImportDbContext:DbContext
    {
        public APsAutoImportDbContext(DbContextOptions<APsAutoImportDbContext>options): base(options)
        {
        }
        public DbSet<Catergory> Catergories {  get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
