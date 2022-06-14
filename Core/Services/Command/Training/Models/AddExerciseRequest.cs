namespace Core.Services.Command.Training.Models;

public record AddExerciseRequest(int ExerciseId, float Weight, int Sets, int Reps);