using Blazor_StudentApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_StudentApp.Connection
{
    public class ApplicationDbContext:DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
