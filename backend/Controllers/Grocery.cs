using Fitdash.Services;
using Fitdash.Models;

namespace Fitdash.Controllers;

public static class Grocery
{
    public static void MapGroceryRoutes(this RouteGroupBuilder group)
    {
        group.MapGet("/", GetGroceries);
        group.MapGet("/{id}", GetGrocery);
        group.MapPost("/", CreateGrocery);
        group.MapPut("/{id}", UpdateGrocery);
        group.MapDelete("/{id}", DeleteGrocery);
    }

    static async Task<IResult> GetGroceries(GroceryService service)
    {
        var groceries = await service.GetAllAsync();
        return TypedResults.Ok(groceries);
    }

    static async Task<IResult> GetGrocery(int id, GroceryService service)
    {
        var grocery = await service.GetByIdAsync(id);
        return grocery is not null ? TypedResults.Ok(grocery) : TypedResults.NotFound();
    }

    static async Task<IResult> CreateGrocery(GroceryItemDTO dto, GroceryService service)
    {
        var created = await service.CreateAsync(dto);
        return TypedResults.Created($"/groceries/{created.Id}", created);
    }

    static async Task<IResult> UpdateGrocery(int id, GroceryItemDTO dto, GroceryService service)
    {
        var updated = await service.UpdateAsync(id, dto);
        return updated ? TypedResults.NoContent() : TypedResults.NotFound();
    }

    static async Task<IResult> DeleteGrocery(int id, GroceryService service)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? TypedResults.NoContent() : TypedResults.NotFound();
    }
}
