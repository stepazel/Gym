using Core.DbStorage.Exercises;
using DbStorage.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DbStorage;

public class DIConfigDbStorage
{
    public static void ConfigureServices(IServiceCollection services)
    {
        // Repositories
        services.AddScoped<IExerciseCategoryRepository, ExerciseCategoryRepository>();

        services.AddDbContext<GymAppContext>(options =>
            options.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=GymApp;MultipleActiveResultSets=true"));
    }
}