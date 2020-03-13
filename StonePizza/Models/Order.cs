using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Models
{
    public class Order
    {
        
        public Order()
        {
            this.orderItems = new List<IMenuItem>();
        }

        [Key]
        public int OrderId { get; set; }

        /// <summary>
        /// The name of the user that places the order
        /// </summary>
        public string NameOnOrder { get; set; }
        
        /// <summary>
        /// The total of every menu item's price in the order items list.
        /// </summary>
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (IMenuItem item in this.orderItems)
                {
                    total += item.ItemPrice;
                }
                return total;
            }
            set
            {
                TotalPrice = value;
            }
        }

        public List<IMenuItem> orderItems { get; set; }
       
       
    }
}
