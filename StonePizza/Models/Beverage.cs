using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class Beverage
    {
        [Key]
        public int BeverageId { get; set; }
        public string BeverageName { get; set; }
        public string BeverageDescription { get; set; }
        public decimal ItemPrice { get; set; }
        /// <summary>
        /// Returns the name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{BeverageName}";
        }
    }
}
