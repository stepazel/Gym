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

    public async Task Add(AddExerciseCategoryCommand command)
    {
        var x = await _db.Database.EnsureCreatedAsync();
        var exerciseCategoryDo = new ExerciseCategoryDo
        {
            Name = command.Name
        };
        await _db.ExerciseCategories.AddAsync(exerciseCategoryDo);
        await _db.SaveChangesAsync();
    }
}