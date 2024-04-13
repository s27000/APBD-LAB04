namespace ProjektLAB04.Visits
{
    public interface IVisitService
    {
        IEnumerable<Visit> GetVisits();

        IEnumerable<Visit> AddVisit(int id, string date, string description, double price);
    }
}
