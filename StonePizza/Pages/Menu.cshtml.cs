using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StonePizza.Models;

namespace StonePizza.Pages
{
    public class MenuModel : PageModel
    {
        public List<SignaturePizza> SignaturePizzas { get; set; }
        public List<Beverage> Beverages { get; set; }
        public List <SideDish> SideDishes { get; set; }


        public void OnGet()
        {

        }
    }
}