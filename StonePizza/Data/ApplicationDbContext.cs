using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StonePizza.Models;

namespace StonePizza.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beverage> Beverages { get; set; }
        public virtual DbSet<SignaturePizza> SignaturePizzas { get; set; }
        public virtual DbSet<SideDish> SideDishes { get; set; }
        public virtual DbSet<CustomPizza> CustomPizzas { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PizzaTopping> Toppings { get; set; }
    }
}
