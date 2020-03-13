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

            Random rnd = new Random();
            int limit = 100;

            base.OnModelCreating(modelBuilder);
            // add your own configuration here
            modelBuilder.Entity<SignaturePizza>()
                .HasData(

                // create SignaturePizzas
                new SignaturePizza
                {
                    PizzaId = rnd.Next(1, limit),
                    ItemName = "The James Brown",
                    ItemPrice = 14.00m,
                    PizzaDescription = "Makes you want to dance!",
                    PizzaCheese = "Mozzarella",
                    PizzaSauce = "Traditional",
                    PizzaCrust = "Traditional",
                    Toppings = new List<string>()
                    {
                        "Pepperoni",
                        "Sausage",
                        "Ham",
                        "Bacon",
                        "Meatball",
                    }
                },
                new SignaturePizza
                {
                    PizzaId = rnd.Next(1, limit),
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
                    PizzaId = rnd.Next(1, limit),
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




            modelBuilder.Entity<Beverage>()
                .HasData(
                // create beverages       
                new Beverage
                {
                    BeverageId = rnd.Next(1, 100),
                    ItemName = "Fountain drink",
                    BeverageDescription = "Carbonated soft drink product from major company",
                    ItemPrice = 1.50m
                },
                new Beverage
                {
                    BeverageId = rnd.Next(1, 100),
                    ItemName = "Beer",
                    BeverageDescription = "Locally brewed craft beer",
                    ItemPrice = 5.50m
                },
                new Beverage
                {
                    BeverageId = rnd.Next(1, 100),
                    ItemName = "Water",
                    BeverageDescription = "Bottled water",
                    ItemPrice = 1.20m
                },
                new Beverage
                {
                    BeverageId = rnd.Next(1, 100),
                    ItemName = "Sports drink",
                    BeverageDescription = "Electrolyte-rich soft drink",
                    ItemPrice = 2.50m
                }

                );


            modelBuilder.Entity<SideDish>()
                .HasData(
                // create SideDishes
                new SideDish
                {
                    SideDishId = rnd.Next(1, 100),
                    ItemName = "Breadsticks",
                    SideDishDescription = "Garlic parmesan butter breadsticks",
                    ItemPrice = 6.99m,
                    Category = "Breadsticks",
                },
                new SideDish
                {
                    SideDishId = rnd.Next(1, 100),
                    ItemName = "Chef Salad",
                    SideDishDescription = "Romaine, bacon, red onion, grape tomato, goat cheese, blue cheese dressing",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    SideDishId = rnd.Next(1, 100),
                    ItemName = "Classic Chicken Caesar",
                    SideDishDescription = "Romaine, all-natural chicken breast, parmesan, crouton, caesar dressing",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    SideDishId = rnd.Next(1, 100),
                    ItemName = "Chopped Antipasto",
                    SideDishDescription = "Romaine, pepperoni, mozzarella, grape tomato, black olive, banana pepper, red onion, red wine vinegar and olive oil vinagrette",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    SideDishId = rnd.Next(1, 100),
                    ItemName = "Bacon & Blu",
                    SideDishDescription = "Romaine, bacon, red onion, grape tomato, goat cheese, blue cheese dressing",
                    ItemPrice = 4.99m,
                    Category = "Salads",
                },
                new SideDish
                {
                    SideDishId = rnd.Next(1, 100),
                    ItemName = "Buffalo Chicken Wings",
                    SideDishDescription = "12 bone-in hot wings doused with Buffalo sauce",
                    ItemPrice = 7.50m,
                    Category = "Chicken Wings",
                },
                new SideDish
                {
                    SideDishId = 7,
                    ItemName = "BBQ Chicken Wings",
                    SideDishDescription = "12 bone-in chicken wings doused with BBQ sauce",
                    ItemPrice = 7.50m,
                    Category = "Chicken Wings",
                }
                
                );


        }

    }
}
