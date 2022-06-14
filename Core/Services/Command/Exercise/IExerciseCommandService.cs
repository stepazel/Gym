using Core.Services.Command.Exercise.Models;

namespace Core.Services.Command.Exercise;

public interface IExerciseCommandService
{
    public void Add(AddExerciseRequest request);
}