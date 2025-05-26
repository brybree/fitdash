namespace Fitdash.Models;

public class GroceryItemDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public float Price { get; set; }

    public GroceryItemDTO() { }
    public GroceryItemDTO(GroceryItem groceryItem)
    {
        (Id, Name, Price) = (groceryItem.Id, groceryItem.Name, groceryItem.Price);

    }
}