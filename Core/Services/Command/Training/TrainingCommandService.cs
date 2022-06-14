using Core.DbStorage.Training;
using Core.Services.Command.Training.Models;

namespace Core.Services.Command.Training;

public class TrainingCommandService : ITrainingCommandService
{
    private readonly ITrainingRepository _trainingRepository;

    public TrainingCommandService(ITrainingRepository trainingRepository)
    {
        _trainingRepository = trainingRepository;
    }

    public void Add()
    {
        // tady mozna udelat validaci, aby se nemohl vytvorit trenink, pokud predchozi neni ukonceny
        _trainingRepository.Add(new AddTrainingCommand(DateTime.Now));
    }

    public void AddExercise(int trainingId, AddExerciseRequest request)
    {
        _trainingRepository.AddExercise(new AddExerciseCommand(trainingId, request.ExerciseId, request.Weight,
            request.Sets, request.Reps));
    }

    public void EndTraining(int trainingId)
    {
        _trainingRepository.EndTraining(new EndTrainingCommand(trainingId, DateTime.Now));
    }
}