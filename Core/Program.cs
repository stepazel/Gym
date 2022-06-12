using Core.Services.Query.Exercise;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IExerciseQueryService, ExerciseQueryService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();