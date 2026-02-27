using System.ComponentModel.DataAnnotations;

namespace Projectmunka.Models
{
    public class Regisztraltak
    {
        public int Id { get; set; }
        [Required]
        public string Neve { get; set; }
        [Required]
        public Boolean IsRegistered { get; set; }
        public string email { get; set; }
        [Required]
        public int telefonszam { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public int iranyitoszam { get; set; }
        [Required]
        public string utca { get; set; }
        [Required]
        public int hazsyam { get; set; }
    }
}
