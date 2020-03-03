using StonePizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StonePizza.Data
{
    /// <summary>
    /// Populates the database 
    /// </summary>
    public static class DatabaseInitializer
    {

        public static void SeedDb( ApplicationDbContext context )
        {
            context.Database.EnsureCreated();
            // create signature pizzas
            var signaturePizzas = new List<SignaturePizza>
            {
                new SignaturePizza
                {
                    ItemName = "The James Brown",
                    ItemPrice = 14.50m,
                    PizzaDescription = "Makes you want to dance!",
                    PizzaCheese = "Mozzarella",
                    PizzaSauce = "Traditional",
                    PizzaCrust = "Traditional",
                    Toppings = new List<PizzaTopping>()
                    {
                        new PizzaTopping("Pepporoni"),
                        new PizzaTopping("Sausage"),
                        new PizzaTopping("Ham"),
                        new PizzaTopping("Bacon"),
                        new PizzaTopping("Meatball"),
                    }
                },
                new SignaturePizza
                {
                    ItemName = "The Ray Charles",
                    ItemPrice = 14.50m,
                    PizzaDescription = "It'll put Georgia on your mind!",
                    PizzaCheese = "Mozzarella",
                    PizzaSauce = "Garlic Alfredo",
                    PizzaCrust = "Traditional",
                    Toppings = new List<PizzaTopping>()
                    {
                        new PizzaTopping("Green Bell Peppers"),
                        new PizzaTopping("Sausage"),
                        new PizzaTopping("Onion"),
                        new PizzaTopping("Fresh Mushroom"),
                        new PizzaTopping("Black Olive"),
                    }
                },
                new SignaturePizza
                {
                    ItemName = "The Stevie Wonder",
                    ItemPrice = 16.50m,
                    PizzaDescription = "It'll make you superstitious!",
                    PizzaCheese = "Vegan Cheese",
                    PizzaSauce = "Traditional",
                    PizzaCrust = "Gluten-free",
                    Toppings = new List<PizzaTopping>()
                    {
                        new PizzaTopping("Vegan Sausage"),
                        new PizzaTopping("Vegan Meatball"),
                        new PizzaTopping("Red Bell Pepper"),
                        new PizzaTopping("Fresh Mushroom"),
                        new PizzaTopping("Black Olive"),
                        new PizzaTopping("Garlic"),
                        new PizzaTopping("Spinach"),
                        new PizzaTopping("Grape Tomato")
                    }
                }


            };

            signaturePizzas.ForEach(s => context.SignaturePizzas.Add(s));
            context.SaveChanges();
        }
    }
}
