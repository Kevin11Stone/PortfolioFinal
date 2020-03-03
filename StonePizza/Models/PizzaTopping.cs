namespace StonePizza.Models
{
    /// <summary>
    /// Single topping on pizza item
    /// </summary>
    public class PizzaTopping
    {
        private decimal ToppingPrice = .25m;
        string ToppingName { get; set; }
        decimal GetToppingPrice() { 
            return ToppingPrice;
        }
    }
}