using System.Net;
using Core.Services.Command.Exercise;
using Core.Services.Query.ExerciseCategory;
using Core.Services.Query.ExerciseCategory.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseCategoryController
{
    private readonly IExerciseCategoryCommandService _exerciseCategoryCommandService;

    private readonly IExerciseCategoryQueryService _exerciseCategoryQueryService;

    public ExerciseCategoryController(IExerciseCategoryCommandService exerciseCategoryCommandService,
        IExerciseCategoryQueryService exerciseCategoryQueryService)
    {
        _exerciseCategoryCommandService = exerciseCategoryCommandService;
        _exerciseCategoryQueryService = exerciseCategoryQueryService;
    }

    [HttpPost]
    public void Add(AddExerciseCategoryRequest request)
    {
        _exerciseCategoryCommandService.Add(request);
    }

    [HttpGet("{id:int}")]
    public GetExerciseCategoryResponse Get(int id)
    {
        var query =  _exerciseCategoryQueryService.Get(id);

        if (query is null)
            throw new BadHttpRequestException($"An Exercise category with id {id} was not found.");

        return new GetExerciseCategoryResponse(query.Id, query.Name);
    }
}