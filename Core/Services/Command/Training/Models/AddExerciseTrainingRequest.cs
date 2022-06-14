namespace Core.Services.Command.Training.Models;

public record AddExerciseTrainingRequest(int ExerciseId, float Weight, int Sets, int Reps);