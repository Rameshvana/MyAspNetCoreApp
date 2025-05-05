using Microsoft.EntityFrameworkCore;
using MvcApplication_pr01.Models.Entitys;
using System;

namespace MvcApplication_pr01.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
