using Core.Services.Command.Exercise;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseCategoryController
{
    private readonly IExerciseCategoryCommandService _exerciseCategoryCommandService;

    public ExerciseCategoryController(IExerciseCategoryCommandService exerciseCategoryCommandService)
    {
        _exerciseCategoryCommandService = exerciseCategoryCommandService;
    }

    [HttpPost]
    public async Task Add(AddExerciseCategoryRequest request)
    {
        await _exerciseCategoryCommandService.Add(request);
    }
}