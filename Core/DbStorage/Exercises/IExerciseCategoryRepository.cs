namespace Core.DbStorage.Exercises;

public interface IExerciseCategoryRepository
{
    public void Add(AddExerciseCategoryCommand command);

    public GetExerciseCategoryQuery? Get(int id);
}