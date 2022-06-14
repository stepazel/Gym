namespace Core.DbStorage.ExerciseCategory;

public interface IExerciseCategoryRepository
{
    public void Add(AddExerciseCategoryCommand command);

    public GetExerciseCategoryQuery? Get(int id);

    public AddExerciseQuery GetForAddExerciseQuery(int id);
}