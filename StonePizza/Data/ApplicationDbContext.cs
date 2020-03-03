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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            // add your own configuration here
            modelBuilder.Entity<SignaturePizza>()
                .HasData(
                    new SignaturePizza
                    {
                        PizzaId = 1,
                        ItemName = "The James Brown",
                        ItemPrice = 14.00m,
                        PizzaDescription = "Makes you want to dance!",
                        PizzaCheese = "Mozzarella",
                        PizzaSauce = "Traditional",
                        PizzaCrust = "Traditional",
                        Toppings = new List<string>()
                    {
                        "Pepporoni",
                        "Sausage",
                        "Ham",
                        "Bacon",
                        "Meatball",
                    }
                    },
                    new SignaturePizza
                    {
                        PizzaId = 2,
                        ItemName = "The Ray Charles",
                        ItemPrice = 14.50m,
                        PizzaDescription = "It'll put Georgia on your mind!",
                        PizzaCheese = "Mozzarella",
                        PizzaSauce = "Garlic Alfredo",
                        PizzaCrust = "Traditional",
                        Toppings = new List<string>()
                    {
                        "Green Bell Peppers",
                        "Sausage",
                        "Onion",
                        "Fresh Mushroom",
                        "Black Olive",
                    }
                    },
                    new SignaturePizza
                    {
                        PizzaId = 3,
                        ItemName = "The Stevie Wonder",
                        ItemPrice = 16.50m,
                        PizzaDescription = "It'll make you superstitious!",
                        PizzaCheese = "Vegan Cheese",
                        PizzaSauce = "Traditional",
                        PizzaCrust = "Gluten-free",
                        Toppings = new List<string>()
                    {
                        "Vegan Sausage",
                        "Vegan Meatball",
                        "Red Bell Pepper",
                        "Fresh Mushroom",
                        "Black Olive",
                        "Garlic",
                        "Spinach",
                        "Grape Tomato"
                    }
                    }
                );
        }

    }
}
