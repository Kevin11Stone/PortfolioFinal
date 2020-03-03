using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class CustomPizza : IMenuItem
    {
        private decimal CustomPizzaPrice = 14.00m;
        private string defaultCustomPizzaName = "Custom Pizza";
      

        public CustomPizza()
        {
            this.CustomPizzaToppings = new List<PizzaTopping>();
        }

        [Key]
        public int CustomPizzaId { get; set; }
        /// <summary>
        /// Returns default name for custom pizzas
        /// </summary>
        public string ItemName
        {
            get
            {
                return defaultCustomPizzaName;
            }
            set
            {
                value = defaultCustomPizzaName;
            }
        }
        public string ItemDescription { get; set; }

        /// <summary>
        /// Returns CustomPizza base price plus toppings 
        /// </summary>
        public decimal GetItemPrice()
        {
            decimal total = CustomPizzaPrice;
            foreach (var t in this.CustomPizzaToppings)
            {
                total += t.GetToppingPrice();
            }
            return total;

        }

        public decimal ItemPrice
        {
            get
            {
                return GetItemPrice();
            }
            set
            {
                value = ItemPrice;
            }
        }



        public string PizzaSauce { get; set; }
        public string PizzaCrust { get; set; }
        public string PizzaCheese { get; set; }

        /// <summary>
        /// Pizza toppings added to a custom pizza
        /// </summary>
        public List<PizzaTopping> CustomPizzaToppings { get; set; }


    }
}
