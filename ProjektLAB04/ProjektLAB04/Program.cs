using ProjektLAB04.Animals;
using ProjektLAB04.Visits;

namespace ProjektLAB04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IAnimalService, AnimalService>();
            builder.Services.AddScoped<IVisitService, VisitService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseAuthorization();

            app.RegisterEndpointsForAnimals();
            app.RegisterEndpointsForVisits();

            app.Run();
        }
    }
}