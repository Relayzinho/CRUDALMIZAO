using Microsoft.EntityFrameworkCore;

namespace CRUDALMIRZAR.Models
{
    public class PetDbContext: DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext> options ) : base( options )
        {

        }
        public DbSet<Pet> Pet { get; set; } 

    }
}
