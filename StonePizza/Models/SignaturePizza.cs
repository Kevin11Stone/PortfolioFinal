using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class SignaturePizza : IMenuItem
    {

        public SignaturePizza()
        {
            this.Toppings = new List<PizzaTopping>();
        }
        [Key]
        public int PizzaId { get; set; }
        public string ItemName { get; set; }
        public string PizzaDescription { get; set; }

        /// <summary>
        /// Returns fixed decimal price of single SignaturePizza
        /// </summary>
        /// <returns></returns>
        public decimal ItemPrice { get; set; }


        /// <summary>
        /// Returns the name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ItemName}";
        }


        // Signature pizza properties
        public string PizzaSauce { get; set; }
        public string PizzaCrust { get; set; }
        public string PizzaCheese { get; set; }

        /// <summary>
        /// List of all toppings on the signature pizza.
        /// </summary>
        public List<PizzaTopping> Toppings { get; set; }

    }
}
