using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class SideDish : IMenuItem
    {
        [Key]
        public int SideDishId { get; set; }

        [Display(Name = "Name")]
        public string ItemName { get; set; }

        [Display(Name = "Description")]
        public string SideDishDescription { get; set; }

        public string Category { get; set; }

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
    }
}
