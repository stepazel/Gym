namespace Core.DbStorage.ExerciseCategory;

// ReSharper disable once InconsistentNaming
public record AddExerciseQuery(AddExerciseQuery.Category? category)
{
    public record Category(int Id);
}