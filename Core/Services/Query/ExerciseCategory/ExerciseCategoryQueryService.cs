using Core.DbStorage.ExerciseCategory;
using Core.DbStorage.Exercises;
using Core.Services.Query.ExerciseCategory.Models;

namespace Core.Services.Query.ExerciseCategory;

public class ExerciseCategoryQueryService : IExerciseCategoryQueryService
{
    private readonly IExerciseCategoryRepository _exerciseCategoryRepository;

    public ExerciseCategoryQueryService(IExerciseCategoryRepository exerciseCategoryRepository)
    {
        _exerciseCategoryRepository = exerciseCategoryRepository;
    }

    public GetExerciseCategoryResponse? Get(int id)
    {
        var query = _exerciseCategoryRepository.Get(id);

        return query is null ? null : new GetExerciseCategoryResponse(query.Id, query.Name);
    }

    public List<GetExerciseCategoryResponse> Get()
    {
        return _exerciseCategoryRepository.Get().Select(x => new GetExerciseCategoryResponse(x.Id, x.Name)).ToList();
    }
}