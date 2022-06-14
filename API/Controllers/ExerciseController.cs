using Core.Services.Command.Exercise;
using Core.Services.Command.Exercise.Models;
using Core.Services.Query.Exercise;
using Core.Services.Query.Exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController
{
    private readonly IExerciseQueryService _exerciseQueryService;

    private readonly IExerciseCommandService _exerciseCommandService;
    
    public ExerciseController(IExerciseQueryService exerciseQueryService, IExerciseCommandService exerciseCommandService)
    {
        _exerciseQueryService = exerciseQueryService;
        _exerciseCommandService = exerciseCommandService;
    }

    [HttpPost("[action]")]
    public void Add(string name, int categoryId)
    {
        _exerciseCommandService.Add(new AddExerciseRequest(name, categoryId));
    }

    [HttpGet("{id:int}")]
    public GetExerciseResponse Get(int id)
    {
        return _exerciseQueryService.Get(id);
    }
}