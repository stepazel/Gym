using Core.DbStorage.ExerciseCategory;
using Core.DbStorage.Exercises;
using Core.Services.Command.Exercise.Models;

namespace Core.Services.Command.Exercise;

public class ExerciseCommandService : IExerciseCommandService
{
    private readonly IExerciseRepository _exerciseRepository;

    private readonly IExerciseCategoryRepository _exerciseCategoryRepository;

    public ExerciseCommandService(IExerciseRepository exerciseRepository, IExerciseCategoryRepository exerciseCategoryRepository)
    {
        _exerciseRepository = exerciseRepository;
        _exerciseCategoryRepository = exerciseCategoryRepository;
    }

    public void Add(AddExerciseRequest request)
    {
        var query = _exerciseCategoryRepository.GetForAddExerciseQuery(request.ExerciseCategoryId);

        if (query.category is null)
            throw new Exception($"Exercise category with id {request.ExerciseCategoryId} doesn't exist.");
        
        _exerciseRepository.Add(new AddExerciseCommand(request.Name, request.ExerciseCategoryId));
    }
}