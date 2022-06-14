namespace Core.DbStorage.Exercises;

public interface IExerciseRepository
{
    public void Add(AddExerciseCommand command);

    public GetExerciseQuery? GetExerciseQuery(int id);

    public List<GetExerciseQuery> GetAll();
}