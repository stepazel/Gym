using Core.Services.Query.Exercise;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController
{
    private IExerciseQueryService _exerciseQueryService;
    
    public ExerciseController(IExerciseQueryService exerciseQueryService)
    {
        _exerciseQueryService = exerciseQueryService;
    }
    
    [HttpGet]
    public async Task<GetExerciseResponse> Get(int id)
    {
        return await _exerciseQueryService.Get(id);
    }
}