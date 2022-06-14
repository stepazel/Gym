using Core.DbStorage.ExerciseCategory;
using Core.DbStorage.Exercises;
using Core.DbStorage.Training;
using DbStorage.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DbStorage;

public class DIConfigDbStorage
{
    public static void ConfigureServices(IServiceCollection services)
    {
        // Repositories
        services.AddScoped<IExerciseCategoryRepository, ExerciseCategoryRepository>();
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<ITrainingRepository, TrainingRepository>();

        services.AddDbContext<GymAppContext>(options =>
            options.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=GymApp;MultipleActiveResultSets=true"));
    }
}