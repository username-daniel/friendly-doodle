using tartine.Model;

namespace tartine.Data;

public class Pizza
{
    public int PizzaId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public bool Vegetarian { get; set; }

    public bool Vegan { get; set; }
    
    public PizzaSpecial Special { get; set; }
    public int SpecialId { get; set; }
    public string? Size { get; set; }
    public static string DefaultSize { get; set; } = "Medium";
    public int MinimumSize { get; set; } = 1;
    public int MaximumSize { get; set; } = 5;
    public List<PizzaTopping> Toppings { get; set; }
    
    public string GetFormattedTotalPrice() => Price.ToString("0.00");
}