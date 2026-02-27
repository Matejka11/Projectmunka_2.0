namespace Projectmunka.Models
{
    public class Rendeles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string telepules { get; set; }
        public string utca {  get; set; }
        public List<Kosar> Kosar { get; set; } = new List<Kosar>();
    }
}
