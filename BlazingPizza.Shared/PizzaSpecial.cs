namespace BlazingPizza;
#nullable enable
/// <summary>
/// Represents a pre-configured template for a pizza a user can order
/// </summary>
public class PizzaSpecial
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public decimal BasePrice { get; set; }

    public required string Description { get; set; }

    public required string ImageUrl { get; set; }

    public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
}