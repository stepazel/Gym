using Core.Services.Query.Exercise;
using Core.Services.Query.Exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController
{
    private readonly IExerciseQueryService _exerciseQueryService;
    
    public ExerciseController(IExerciseQueryService exerciseQueryService)
    {
        _exerciseQueryService = exerciseQueryService;
    }
}