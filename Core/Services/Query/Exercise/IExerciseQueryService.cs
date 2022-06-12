using Core.Services.Query.Exercise.Models;

namespace Core.Services.Query.Exercise;

public interface IExerciseQueryService
{
    public Task<Models.Exercise> Get(int id);

}