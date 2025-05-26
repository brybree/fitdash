using Microsoft.EntityFrameworkCore;
using Fitdash.Models;

namespace Fitdash.Services;

public class GroceryService
{
    private readonly FitdashDbContext _db;

    public GroceryService(FitdashDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<GroceryItemDTO>> GetAllAsync()
    {
        return await _db.Groceries.Select(x => new GroceryItemDTO(x)).ToListAsync();
    }

    public async Task<GroceryItemDTO?> GetByIdAsync(int id)
    {
        var grocery = await _db.Groceries.FindAsync(id);
        return grocery is null ? null : new GroceryItemDTO(grocery);
    }

    public async Task<GroceryItemDTO> CreateAsync(GroceryItemDTO dto)
    {
        var grocery = new GroceryItem
        {
            Name = dto.Name,
            Price = dto.Price
        };
        _db.Groceries.Add(grocery);
        await _db.SaveChangesAsync();
        return new GroceryItemDTO(grocery);
    }

    public async Task<bool> UpdateAsync(int id, GroceryItemDTO dto)
    {
        var grocery = await _db.Groceries.FindAsync(id);
        if (grocery is null) return false;

        grocery.Name = dto.Name;
        grocery.Price = dto.Price;
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var grocery = await _db.Groceries.FindAsync(id);
        if (grocery is null) return false;

        _db.Groceries.Remove(grocery);
        await _db.SaveChangesAsync();
        return true;
    }
}
