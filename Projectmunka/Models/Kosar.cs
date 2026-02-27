namespace Projectmunka.Models
{
    public class Kosar
    {
        public int Id { get; set; }

        public int RegisztraltakId { get; set; }   // melyik user
        public int TermekId { get; set; }          // melyik termék

        public int Mennyiseg { get; set; }

        public DateTime RendelesIdopont { get; set; } = DateTime.Now;
    }
}
