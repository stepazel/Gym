using Core.Services.Query.Exercise.Models;

namespace Core.Services.Query.Exercise;

public interface IExerciseQueryService
{
    public GetExerciseResponse Get(int id);
}