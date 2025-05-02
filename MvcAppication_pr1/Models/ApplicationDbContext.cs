using Microsoft.EntityFrameworkCore;

namespace MvcAppication_pr1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<SiteManag> tb_Site { get; set; }

    }
}
