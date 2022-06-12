using Core.Services.Query.ExerciseCategory.Models;

namespace Core.Services.Query.ExerciseCategory;

public interface IExerciseCategoryQueryService
{
    public GetExerciseCategoryResponse? Get(int id);
}