using Core.Services.Command.Training;
using Core.Services.Command.Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TrainingController
{
    private readonly ITrainingCommandService _trainingCommandService;

    public TrainingController(ITrainingCommandService trainingCommandService)
    {
        _trainingCommandService = trainingCommandService;
    }

    [HttpPost("[action]")]
    public void Add()
    {
        _trainingCommandService.Add();
    }

    [HttpPost("{trainingId:int}/[action]")]
    public void AddExercise(int trainingId, AddExerciseRequest request)
    {
        _trainingCommandService.AddExercise(trainingId, request);
    }

    [HttpPost("{trainingId:int}/[action]")]
    public void EndTraining(int trainingId)
    {
        _trainingCommandService.EndTraining(trainingId);
    }
}