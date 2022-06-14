namespace Core.DbStorage.Training;

public record AddExerciseCommand(int TrainingId, int ExerciseId, float Weight, int Sets, int Reps);