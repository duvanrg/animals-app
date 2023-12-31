using System.Reflection;
using ApiAnimals.Extensions;
using AspNetCoreRateLimit;
using Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();

builder.Services.ConfigureRateLimiting();

builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAplicationServices();

builder.Services.AddDbContext<AnimalContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("MySqlConex");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseIpRateLimiting();

app.UseAuthorization();

app.MapControllers();

app.Run();

// dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project .\ApiAnimals\ --output-dir ./Data/Migrations
// dotnet ef database update --project ./Infrastructure/ --startup-project ./ApiAnimals/