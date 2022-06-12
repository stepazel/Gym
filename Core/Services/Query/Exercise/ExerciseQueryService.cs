using Core.Services.Query.Exercise.Models;

namespace Core.Services.Query.Exercise;

public class ExerciseQueryService : IExerciseQueryService
{
    public Task<Models.Exercise> Get(int id)
    {
        throw new NotImplementedException();
    }

    public ExerciseCategory GetCategory(int id)
    {
        return new ExerciseCategory(id, "Legs");
    }
}