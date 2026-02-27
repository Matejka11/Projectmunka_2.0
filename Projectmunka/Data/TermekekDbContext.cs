using Microsoft.EntityFrameworkCore;
using Projectmunka.Models;

namespace Projectmunka.Data
{
    public class TermekekDbContext : DbContext
    {
        public TermekekDbContext(DbContextOptions<TermekekDbContext> options)
            : base(options) { }

        public DbSet<Termekek> Termekek { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Termekek>().HasData(
                new Termekek
                {
                    Id = 1,
                    Name = "Kalos sampon 1L",
                    Price = 1550,
                    Kep = "kalos1l.jpg",
                    Darab = 2,
                    Fajta = "Sampon"
                },
                new Termekek
                {
                    Id = 2,
                    Name = "BABA Testápoló 400ml",
                    Price = 1699,
                    Kep = "baba_testapolo.jpg",
                    Darab = 3,
                    Fajta = "Testápoló"
                },
                new Termekek 
                { 
                    Id = 3,
                    Name = "DAV Folyékony Szappan 500ml",
                    Price = 1050,
                    Kep = "dav_szappan.jpg",
                    Darab = 6, Fajta = "Szappan" },
                new Termekek 
                { 
                    Id = 4,
                    Name = "DAV Tusfürdő 450ml",
                    Price = 1490,
                    Kep = "dav_tus_450.jpg",
                    Darab = 4,
                    Fajta = "Tusfürdő" },
                new Termekek
                {
                    Id = 5,
                    Name = "DAV Tusfürdő 720ml",
                    Price = 1990,
                    Kep = "dav_tus_720.jpg",
                    Darab = 3,
                    Fajta = "Tusfürdő" },
                new Termekek 
                { 
                    Id = 6,
                    Name = "Corega Műfogsor Tisztító Tabletta 30db",
                    Price = 1699,
                    Kep = "corega.jpg",
                    Darab = 2,
                    Fajta = "Szájápolás" },
                new Termekek { Id = 7, Name = "Blend-a-dent Protézis Rögzítő 47g", Price = 1560, Kep = "blendadent.jpg", Darab = 12, Fajta = "Szájápolás" },
                new Termekek { Id = 8, Name = "Palmolive Folyékony Szappan 100ml", Price = 1150, Kep = "palmolive.jpg", Darab = 3, Fajta = "Szappan" },
                new Termekek { Id = 9, Name = "Signal Fogkrém 75ml", Price = 599, Kep = "signal.jpg", Darab = 8, Fajta = "Fogkrém" },
                new Termekek { Id = 10, Name = "Adams Aftershave 100ml", Price = 599, Kep = "adams.jpg", Darab = 9, Fajta = "Aftershave" },
                new Termekek { Id = 11, Name = "Astra Penge", Price = 299, Kep = "astra.jpg", Darab = 25, Fajta = "Borotválkozás" },
                new Termekek { Id = 12, Name = "Oral-B Fogkefe", Price = 299, Kep = "oralb.jpg", Darab = 7, Fajta = "Fogkefe" },
                new Termekek { Id = 13, Name = "Tic-Tac Orange 18g", Price = 235, Kep = "tictac.jpg", Darab = 23, Fajta = "Édesség" },
                new Termekek { Id = 14, Name = "Palette Hajfesték 50ml", Price = 1299, Kep = "palette.jpg", Darab = 18, Fajta = "Hajfesték" },
                new Termekek { Id = 15, Name = "Parfüm Lucian Lebron 30ml", Price = 999, Kep = "parfum.jpg", Darab = 8, Fajta = "Parfüm" },
                new Termekek { Id = 16, Name = "Lux Szappan", Price = 299, Kep = "lux.jpg", Darab = 28, Fajta = "Szappan" },
                new Termekek { Id = 17, Name = "Baba Szappan 90g", Price = 389, Kep = "baba_szappan.jpg", Darab = 8, Fajta = "Szappan" },
                new Termekek { Id = 18, Name = "Argan Hajmaszk 275ml", Price = 810, Kep = "argan.jpg", Darab = 2, Fajta = "Hajápolás" },
                new Termekek { Id = 19, Name = "Nivea Krém 75ml", Price = 1050, Kep = "nivea.jpg", Darab = 2, Fajta = "Krém" },
                new Termekek { Id = 20, Name = "Syoss Sampon 440ml", Price = 1820, Kep = "syoss.jpg", Darab = 3, Fajta = "Sampon" },
                new Termekek { Id = 21, Name = "Schauma Sampon 480ml", Price = 1399, Kep = "schauma.jpg", Darab = 2, Fajta = "Sampon" },
                new Termekek { Id = 22, Name = "Gliss Sampon 250ml", Price = 1399, Kep = "gliss_sampon.jpg", Darab = 2, Fajta = "Sampon" },
                new Termekek { Id = 23, Name = "Gliss Balzsam 200ml", Price = 1399, Kep = "gliss_balzsam.jpg", Darab = 2, Fajta = "Balzsam" }
            );
        }
    }
}