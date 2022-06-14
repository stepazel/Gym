using Core.DbStorage.Exercises;
using Core.Services.Query.Exercise.Models;

namespace Core.Services.Query.Exercise;

public class ExerciseQueryService : IExerciseQueryService
{
    private readonly IExerciseRepository _exerciseRepository;

    public ExerciseQueryService(IExerciseRepository exerciseRepository)
    {
        _exerciseRepository = exerciseRepository;
    }

    public GetExerciseResponse Get(int id)
    {
        var query = _exerciseRepository.GetExerciseQuery(id);

        if (query is null)
            throw new Exception($"An exercise with id {id} doesn't exist");
        
        return new GetExerciseResponse(query.Name, query.CategoryName, query.CategoryId, query.Id);
    }

    public List<GetExerciseResponse> GetAll()
    {
        return _exerciseRepository
            .GetAll()
            .Select(x => new GetExerciseResponse(x.Name, x.CategoryName, x.CategoryId, x.Id))
            .ToList();
    }
}