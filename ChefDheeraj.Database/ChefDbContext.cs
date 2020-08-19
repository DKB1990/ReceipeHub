using ChefDheeraj.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefDheeraj.Database
{
    public class ChefDbContext : DbContext
    {

        public ChefDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Receipe> Receipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
