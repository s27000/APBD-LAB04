namespace ProjektLAB04.Animals
{
    public static class Configuration
    {
        public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/animals", (IAnimalService service) =>
            {
                return TypedResults.Ok(service.GetAnimals());
            });

            app.MapGet("/api/v1/animals/{id:int}", (IAnimalService service, int id) =>
            {
                return TypedResults.Ok(service.GetAnimalById(id));
            });

            app.MapPost("/api/v1/animals", (IAnimalService service, Animal newAnimal) =>
            {
                return TypedResults.Ok(service.AddAnimal(newAnimal));
            });

            app.MapPut("/api/v1/animals/{id:int}", (IAnimalService service, int id, Animal modifiedAnimal) =>
            {
                return TypedResults.Ok(service.ModifyAnimal(id,modifiedAnimal));
            });

            app.MapDelete("/api/v1/animals", (IAnimalService service, int id) =>
            {
                return TypedResults.Ok(service.RemoveAnimal(id));
            });
        }
    }
}
