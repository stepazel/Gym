using Core.Services.Command.Training.Models;

namespace Core.Services.Command.Training;

public interface ITrainingCommandService
{
    public void Add();

    public void AddExercise(int trainingId, AddExerciseTrainingRequest trainingRequest);

    public void EndTraining(int trainingId);
}