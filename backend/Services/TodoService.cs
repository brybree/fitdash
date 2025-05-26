using Microsoft.EntityFrameworkCore;
using Fitdash.Models;

namespace Fitdash.Services;

public class TodoService
{
    private readonly TodoDb _db;

    public TodoService(TodoDb db)
    {
        _db = db;
    }

    public async Task<IEnumerable<TodoItemDTO>> GetAllAsync()
    {
        return await _db.Todos.Select(x => new TodoItemDTO(x)).ToListAsync();
    }

    public async Task<TodoItemDTO?> GetByIdAsync(int id)
    {
        var todo = await _db.Todos.FindAsync(id);
        return todo is null ? null : new TodoItemDTO(todo);
    }

    public async Task<TodoItemDTO> CreateAsync(TodoItemDTO dto)
    {
        var todo = new Todo { Name = dto.Name };
        _db.Todos.Add(todo);
        await _db.SaveChangesAsync();
        return new TodoItemDTO(todo);
    }

    public async Task<bool> UpdateAsync(int id, TodoItemDTO dto)
    {
        var todo = await _db.Todos.FindAsync(id);
        if (todo is null) return false;

        todo.Name = dto.Name;
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var todo = await _db.Todos.FindAsync(id);
        if (todo is null) return false;

        _db.Todos.Remove(todo);
        await _db.SaveChangesAsync();
        return true;
    }
}
