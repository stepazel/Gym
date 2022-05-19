namespace Core.Services.Query.Exercise;

public interface IExerciseQueryService
{
    Task<GetExerciseResponse> Get(int id);
}