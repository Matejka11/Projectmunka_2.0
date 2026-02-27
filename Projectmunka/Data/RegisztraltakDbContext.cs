using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Projectmunka.Models;

namespace Projectmunka.Data

{
    public class RegisztraltakDbContext : DbContext
    {
        public RegisztraltakDbContext(DbContextOptions<RegisztraltakDbContext> options) : base(options) { }

        public DbSet<Regisztraltak> Regisztraltak { get; set; }
        public DbSet<Beleptettek> Beleptettek { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        }
}
