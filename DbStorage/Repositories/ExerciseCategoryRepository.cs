using Core.DbStorage.ExerciseCategory;
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

    public AddExerciseQuery GetForAddExerciseQuery(int id)
    {
        var exerciseCategoryDo = GetById(id);

        return new AddExerciseQuery(exerciseCategoryDo is null ? null : new AddExerciseQuery.Category(id));
    }

    public List<GetExerciseCategoryQuery> Get()
    {
        return _db.ExerciseCategories.Select(x => new GetExerciseCategoryQuery(x.Id, x.Name)).ToList();
    }

    private ExerciseCategoryDo? GetById(int id)
    {
        return _db.ExerciseCategories.FirstOrDefault(exerciseCategoryDo => exerciseCategoryDo.Id == id);
    }
}