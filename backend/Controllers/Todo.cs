using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http.HttpResults;
using Fitdash.Services;
using Fitdash.Models;

namespace Fitdash.Controllers;

public static class Todo
{
    public static void MapTodoRoutes(this RouteGroupBuilder group)
    {
        group.MapGet("/", GetAllTodos);
        group.MapGet("/{id}", GetTodo);
        group.MapPost("/", CreateTodo);
        group.MapPut("/{id}", UpdateTodo);
        group.MapDelete("/{id}", DeleteTodo);
    }

    static async Task<IResult> GetAllTodos(TodoService service)
    {
        var todos = await service.GetAllAsync();
        return TypedResults.Ok(todos);
    }

    static async Task<IResult> GetTodo(int id, TodoService service)
    {
        var todo = await service.GetByIdAsync(id);
        return todo is not null ? TypedResults.Ok(todo) : TypedResults.NotFound();
    }

    static async Task<IResult> CreateTodo(TodoItemDTO dto, TodoService service)
    {
        var created = await service.CreateAsync(dto);
        return TypedResults.Created($"/todoitems/{created.Id}", created);
    }

    static async Task<IResult> UpdateTodo(int id, TodoItemDTO dto, TodoService service)
    {
        var updated = await service.UpdateAsync(id, dto);
        return updated ? TypedResults.NoContent() : TypedResults.NotFound();
    }

    static async Task<IResult> DeleteTodo(int id, TodoService service)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? TypedResults.NoContent() : TypedResults.NotFound();
    }
}
