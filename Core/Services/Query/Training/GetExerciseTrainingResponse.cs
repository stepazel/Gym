namespace Core.Services.Query.Training;

public record GetExerciseTrainingResponse(string ExerciseName, int ExerciseId, float Weight, int Sets, int Reps);