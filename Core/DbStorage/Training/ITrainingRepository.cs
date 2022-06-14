namespace Core.DbStorage.Training;

public interface ITrainingRepository
{
    public void Add(AddTrainingCommand command);

    public void AddExercise(AddExerciseCommand command);

    public void EndTraining(EndTrainingCommand command);
}