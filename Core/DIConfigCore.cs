using Core.Services.Command.Exercise;
using Core.Services.Query.Exercise;

namespace Core;

public class DIConfigCore
{
    public static void ConfigureServices(IServiceCollection services)
    {
        // Query services
        services.AddScoped<IExerciseQueryService, ExerciseQueryService>();
        
        // Command services
        services.AddScoped<IExerciseCategoryCommandService, ExerciseCategoryCommandService>();
    }
}