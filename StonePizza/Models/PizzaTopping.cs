using System.ComponentModel.DataAnnotations;

namespace StonePizza.Models
{
    /// <summary>
    /// Single topping on pizza item
    /// </summary>
    public class PizzaTopping
    {
       
        private decimal ToppingPrice = .25m;

        public PizzaTopping(string name)
        {
            ToppingName = name;
        }

        [Key]
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public decimal GetToppingPrice() { 
            return ToppingPrice;
        }


    }


}