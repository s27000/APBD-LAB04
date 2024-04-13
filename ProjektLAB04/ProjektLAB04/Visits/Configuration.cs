using ProjektLAB04.Animals;

namespace ProjektLAB04.Visits
{
    public static class Configuration
    {
        public static void RegisterEndpointsForVisits(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/visits", (IVisitService service) =>
            {
                return TypedResults.Ok(service.GetVisits());
            });

            app.MapPost("/api/v1/visits", (IVisitService service, int id, string date, string description, double price) =>
            {
                return TypedResults.Ok(service.AddVisit(id, date, description, price));
            });

        }
    }
}
