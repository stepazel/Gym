using Core.DbStorage.Exercises;
using DbStorage.DatabaseObjects;
using Microsoft.EntityFrameworkCore;

namespace DbStorage.Repositories;

public class ExerciseRepository : IExerciseRepository
{
    private readonly GymAppContext _db;

    public ExerciseRepository(GymAppContext db)
    {
        _db = db;
    }

    public void Add(AddExerciseCommand command)
    {
        var exerciseDo = new ExerciseDo
        {
            Name = command.Name,
            CategoryDoId = command.CategoryId
        };
        _db.Add(exerciseDo);
        _db.SaveChanges();
    }

    public GetExerciseQuery? GetExerciseQuery(int id)
    {
        var exerciseDo = _db.Exercises
            .Include(exerciseDo => exerciseDo.CategoryDo)
            .FirstOrDefault(exerciseDo => exerciseDo.Id == id);

        return exerciseDo is not null
            ? new GetExerciseQuery(exerciseDo.Name, exerciseDo.CategoryDo.Name, exerciseDo.CategoryDoId)
            : null;
    }
}