using Core.DbStorage.Exercises;

namespace Core.Services.Command.Exercise;

public class ExerciseCategoryCommandService : IExerciseCategoryCommandService
{
    private readonly IExerciseCategoryRepository _exerciseCategoryRepository;

    public ExerciseCategoryCommandService(IExerciseCategoryRepository exerciseCategoryRepository)
    {
        _exerciseCategoryRepository = exerciseCategoryRepository;
    }

    public async Task Add(AddExerciseCategoryRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new BadHttpRequestException("The name must contain some characters.");

        await _exerciseCategoryRepository.Add(new AddExerciseCategoryCommand(request.Name));
    }
}