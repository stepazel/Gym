namespace Core.DbStorage.Exercises;

public interface IExerciseCategoryRepository
{
    public Task Add(AddExerciseCategoryCommand command);
}