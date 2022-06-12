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
}