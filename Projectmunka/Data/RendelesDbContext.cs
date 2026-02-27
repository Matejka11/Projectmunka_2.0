using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Projectmunka.Models;

namespace Projectmunka.Data
{
    public class RendelesDbContext : DbContext
    {
        public RendelesDbContext(DbContextOptions<RendelesDbContext> options) : base(options) { }
        public DbSet<Kosar> Kosar { get; set; }
        public DbSet<Rendeles> Rendeles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
