using Core.DbStorage.Exercises;
using DbStorage.DatabaseObjects;

namespace DbStorage.Repositories;

public class ExerciseCategoryRepository : IExerciseCategoryRepository
{
    private readonly GymAppContext _db;

    public ExerciseCategoryRepository(GymAppContext db)
    {
        _db = db;
    }

    public void Add(AddExerciseCategoryCommand command)
    {
        var exerciseCategoryDo = new ExerciseCategoryDo
        {
            Name = command.Name
        };
        _db.ExerciseCategories.Add(exerciseCategoryDo);
        _db.SaveChanges();
    }

    public GetExerciseCategoryQuery? Get(int id)
    {
        var exerciseCategoryDo = _db.ExerciseCategories
            .FirstOrDefault(exerciseCategoryDo => exerciseCategoryDo.Id == id);

        return exerciseCategoryDo is null 
            ? null 
            : new GetExerciseCategoryQuery(exerciseCategoryDo.Id, exerciseCategoryDo.Name);
    }
}