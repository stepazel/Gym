namespace Core.Services.Query.Exercise;

public class ExerciseQueryService : IExerciseQueryService
{
    public async Task<GetExerciseResponse> Get(int id)
    {
        return new GetExerciseResponse("Bench Press", new ExerciseCategory("Chest"));
    }
}