using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace varren.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Tenta> Tentamen { get; set; }

        public DbSet<Övning> Övningar { get; set; }

        public DbSet<Labb> Labbar { get; set; }

        public DbSet<Kod> Code { get; set; }
    }
}
