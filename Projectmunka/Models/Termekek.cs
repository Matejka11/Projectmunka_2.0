using System.ComponentModel.DataAnnotations;

namespace Projectmunka.Models
{
    public class Termekek
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Range(1, 20000)]
        public string Kep { get; set; }
        public int Darab { get; set; }
        [Required]
        public string Fajta { get; set; }
    }
}
