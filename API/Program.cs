using Core;
using DbStorage;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

DIConfigCore.ConfigureServices(builder.Services);
DIConfigDbStorage.ConfigureServices(builder.Services);

var app = builder.Build();

app.UseCors(policy => 
    policy.WithOrigins("http://localhost:7058", "https://localhost:7058")
        .AllowAnyMethod()
        .WithHeaders(HeaderNames.ContentType));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();