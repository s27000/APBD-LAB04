using ProjektLAB04.Animals;

namespace ProjektLAB04.Visits
{
    public class VisitService : IVisitService
    {
        private IAnimalService animalService;
        private static List<Visit> VisitList = new List<Visit>();

        public VisitService()
        {
            animalService = new AnimalService();
        }
        public IEnumerable<Visit> GetVisits()
        {
            return VisitList;
        }

        public IEnumerable<Visit> AddVisit(int id, string date, string description, double price)
        {
            Visit visit = new Visit();
            visit.Date = date;
            visit.Animal = animalService.GetAnimalById(id);
            visit.Description = description;
            visit.Price = price;

            VisitList.Add(visit);
            return VisitList;
        }
    }
}
