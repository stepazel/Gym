namespace Core.Services.Command.Exercise;

public interface IExerciseCategoryCommandService
{
    public Task Add(AddExerciseCategoryRequest request);
}