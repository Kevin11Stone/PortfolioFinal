namespace StonePizza.Models
{
    /// <summary>
    /// Single topping on pizza item
    /// </summary>
    public class PizzaTopping
    {
        private decimal ToppingPrice = .25m;
        public string ToppingName { get; set; }
        public decimal GetToppingPrice() { 
            return ToppingPrice;
        }
    }
}