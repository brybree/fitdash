namespace Fitdash.Models;

public class GroceryItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public float Price { get; set; }
    public string? Secret { get; set; }
}