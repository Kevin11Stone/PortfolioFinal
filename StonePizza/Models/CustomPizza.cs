using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class CustomPizza
    {
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
        public string GetName()
        {
            return defaultCustomPizzaName;
        }
        public string ItemDescription { get; set; }
        //public decimal ItemPrice { 
        //    get
        //    {
        //        decimal total = 14.00m;
        //        foreach (var t in this.CustomPizzaToppings)
        //        {
        //            total += t
        //        }
                    
        //    }
        //}
        public string PizzaSauce { get; set; }
        public string PizzaCrust { get; set; }
        public string PizzaCheese { get; set; }

        /// <summary>
        /// Pizza toppings added to a custom pizza.
        /// </summary>
        public List<PizzaTopping> CustomPizzaToppings { get; set; }


    }
}
