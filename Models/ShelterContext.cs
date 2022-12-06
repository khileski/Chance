using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class ShelterDbContext : DbContext {
        public ShelterDbContext(DbContextOptions<ShelterDbContext> options) 
        :base(options)
        {

        }
        public DbSet<Shelter>Shelters {get;set;} = default!;
        public DbSet<Animal>Animals {get;set;} = default!;
        
    }
}