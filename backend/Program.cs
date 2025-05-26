using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Fitdash.Controllers;
using Fitdash.Services;
using Fitdash.Models;

//code mostly from https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<TodoDb>(options =>
 options.UseSqlite(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddOutputCache(options =>
{
    options.AddBasePolicy(policy => policy.Expire(TimeSpan.FromMinutes(10)));
});

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<TodoService>();

var app = builder.Build();

app.UseOutputCache();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi().CacheOutput();
    app.MapScalarApiReference();
}

RouteGroupBuilder todoItems = app.MapGroup("/todoitems");

todoItems.MapTodoRoutes();

app.Run();