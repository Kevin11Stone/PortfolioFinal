using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class SignaturePizza : IMenuItem
    {

        public SignaturePizza()
        {
            this.Toppings = new List<string>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PizzaId { get; set; }

        [Display(Name = "Name")]
        public string ItemName { get; set; }
        [Display(Name = "Description")]
        public string PizzaDescription { get; set; }

        /// <summary>
        /// Returns fixed decimal price of single SignaturePizza
        /// </summary>
        /// <returns></returns>
        [Display(Name = "Price")]
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
        [Display(Name = "Sauce")]
        public string PizzaSauce { get; set; }
        [Display(Name = "Crust")]
        public string PizzaCrust { get; set; }
        [Display(Name = "Cheese")]
        public string PizzaCheese { get; set; }

        /// <summary>
        /// List of all toppings on the signature pizza.
        /// </summary>
        [NotMapped]
        [Display(Name = "Toppings")]
        public List<string> Toppings { get; set; }

        public string GetToppings()
        {
            string space = ", ";
            var listOfToppings = new StringBuilder();

            listOfToppings.Append(this.Toppings[0]);
            for (int i = 1; i < this.Toppings.Count(); i++)
            {
                listOfToppings.Append(space);
                listOfToppings.Append(this.Toppings[i]);
            }
            return listOfToppings.ToString();
        }

    }
}
