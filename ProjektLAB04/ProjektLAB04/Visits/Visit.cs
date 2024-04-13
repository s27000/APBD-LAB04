using ProjektLAB04.Animals;

namespace ProjektLAB04.Visits
{
    public class Visit
    {
        public string? Date { get; set; }

        public Animal Animal { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
