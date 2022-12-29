using Microsoft.EntityFrameworkCore;

namespace astroNerds.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<HResult> HResults { get; set; }
        public DbSet<Zodiac> Zodiac { get; set; }
    }
}
