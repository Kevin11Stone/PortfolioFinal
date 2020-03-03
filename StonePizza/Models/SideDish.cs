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
        public string ItemName { get; set; }
        public string SideDishDescription { get; set; }
        public string Category { get; set; }
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
