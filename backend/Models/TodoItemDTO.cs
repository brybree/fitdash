namespace Fitdash.Models;

public class TodoItemDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem)
    {
        (Id, Name) = (todoItem.Id, todoItem.Name);

    }
}