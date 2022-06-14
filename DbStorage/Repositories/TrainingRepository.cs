using Core.DbStorage.Training;
using DbStorage.DatabaseObjects;

namespace DbStorage.Repositories;

public class TrainingRepository : ITrainingRepository
{
    private GymAppContext _db;

    public TrainingRepository(GymAppContext db)
    {
        _db = db;
    }

    public void Add(AddTrainingCommand command)
    {
        var trainingDo = new TrainingDo
        {
            Start = command.Start
        };
        _db.Trainings.Add(trainingDo);
        _db.SaveChanges();
    }

    public void AddExercise(AddExerciseCommand command)
    {
        var exerciseTrainingDo = new ExerciseTrainingDo
        {
            ExerciseDoId = command.ExerciseId,
            TrainingDoId = command.TrainingId,
            Weight = command.Weight,
            Reps = command.Reps,
            Sets = command.Sets
        };
        _db.ExerciseTrainings.Add(exerciseTrainingDo);
        _db.SaveChanges();
    }

    public void EndTraining(EndTrainingCommand command)
    {
        var trainingDo = _db.Trainings.FirstOrDefault(x => x.Id == command.Id);

        if (trainingDo is null)
            return;

        trainingDo.End = command.EndDate;
        _db.SaveChanges();
    }
}