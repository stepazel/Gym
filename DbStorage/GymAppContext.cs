using DbStorage.DatabaseObjects;
using Microsoft.EntityFrameworkCore;

namespace DbStorage;

public class GymAppContext : DbContext
{
    public GymAppContext(DbContextOptions<GymAppContext> options) : base(options)
    {
    }

    public DbSet<ExerciseCategoryDo> ExerciseCategories => Set<ExerciseCategoryDo>();

    public DbSet<ExerciseDo> Exercises => Set<ExerciseDo>();

    public DbSet<TrainingDo> Trainings => Set<TrainingDo>();

    public DbSet<ExerciseTrainingDo> ExerciseTrainings => Set<ExerciseTrainingDo>();
}