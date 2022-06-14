using Core.Services.Command.Training;
using Core.Services.Command.Training.Models;
using Core.Services.Query.Training;
using DbStorage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TrainingController
{
    private readonly ITrainingCommandService _trainingCommandService;

    // tohle bych nemel haha
    private readonly GymAppContext _db;

    public TrainingController(ITrainingCommandService trainingCommandService, GymAppContext db)
    {
        _trainingCommandService = trainingCommandService;
        _db = db;
    }

    [HttpPost("[action]")]
    public void Add()
    {
        _trainingCommandService.Add();
    }

    [HttpGet("[action]")]
    public int GetLastTrainingId()
    {
        return _db.Trainings.FirstOrDefault(x => x.End == null)!.Id;
    }

    [HttpPost("{trainingId:int}/[action]")]
    public void AddExercise(int trainingId, AddExerciseTrainingRequest trainingRequest)
    {
        _trainingCommandService.AddExercise(trainingId, trainingRequest);
    }

    [HttpPost("{trainingId:int}/[action]")]
    public void EndTraining(int trainingId)
    {
        _trainingCommandService.EndTraining(trainingId);
    }

    [HttpGet("[action]")]
    public List<GetExerciseTrainingResponse> GetExerciseTrainings()
    {
        return _db.ExerciseTrainings
            .Include(x => x.ExerciseDo)
            .Select(x => new GetExerciseTrainingResponse(x.ExerciseDo.Name, x.ExerciseDoId, x.Weight, x.Sets, x.Reps))
            .ToList();
    }
}