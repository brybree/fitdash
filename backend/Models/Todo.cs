namespace Fitdash.Models;

public class Todo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Secret { get; set; }
}