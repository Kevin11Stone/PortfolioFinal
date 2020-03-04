using Microsoft.EntityFrameworkCore.Migrations;

namespace StonePizza.Data.Migrations
{
    public partial class menuConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "BeverageId", "BeverageDescription", "ItemName", "ItemPrice" },
                values: new object[,]
                {
                    { 4, "Carbonated soft drink product from major company", "Fountain drink", 1.50m },
                    { 99, "Locally brewed craft beer", "Beer", 5.50m },
                    { 95, "Bottled water", "Water", 1.20m },
                    { 66, "Electrolyte-rich soft drink", "Sports drink", 2.50m }
                });

            migrationBuilder.InsertData(
                table: "SideDishes",
                columns: new[] { "SideDishId", "Category", "ItemName", "ItemPrice", "SideDishDescription" },
                values: new object[,]
                {
                    { 86, "Breadsticks", "Breadsticks", 6.99m, "Garlic parmesan butter breadsticks" },
                    { 69, "Salads", "Chef Salad", 4.99m, "Romaine, bacon, red onion, grape tomato, goat cheese, blue cheese dressing" },
                    { 42, "Salads", "Classic Chicken Caesar", 4.99m, "Romaine, all-natural chicken breast, parmesan, crouton, caesar dressing" },
                    { 85, "Salads", "Chopped Antipasto", 4.99m, "Romaine, pepperoni, mozzarella, grape tomato, black olive, banana pepper, red onion, red wine vinegar and olive oil vinagrette" },
                    { 98, "Salads", "Bacon & Blu", 4.99m, "Romaine, bacon, red onion, grape tomato, goat cheese, blue cheese dressing" },
                    { 25, "Chicken Wings", "Buffalo Chicken Wings", 7.50m, "12 bone-in hot wings doused with Buffalo sauce" },
                    { 7, "Chicken Wings", "BBQ Chicken Wings", 7.50m, "12 bone-in chicken wings doused with BBQ sauce" }
                });

            migrationBuilder.InsertData(
                table: "SignaturePizzas",
                columns: new[] { "PizzaId", "ItemName", "ItemPrice", "PizzaCheese", "PizzaCrust", "PizzaDescription", "PizzaSauce" },
                values: new object[,]
                {
                    { 61, "The James Brown", 14.00m, "Mozzarella", "Traditional", "Makes you want to dance!", "Traditional" },
                    { 18, "The Ray Charles", 14.50m, "Mozzarella", "Traditional", "It'll put Georgia on your mind!", "Garlic Alfredo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "BeverageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "BeverageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "BeverageId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "BeverageId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SideDishes",
                keyColumn: "SideDishId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 61);

            migrationBuilder.InsertData(
                table: "SignaturePizzas",
                columns: new[] { "PizzaId", "ItemName", "ItemPrice", "PizzaCheese", "PizzaCrust", "PizzaDescription", "PizzaSauce" },
                values: new object[] { 1, "The James Brown", 14.00m, "Mozzarella", "Traditional", "Makes you want to dance!", "Traditional" });

            migrationBuilder.InsertData(
                table: "SignaturePizzas",
                columns: new[] { "PizzaId", "ItemName", "ItemPrice", "PizzaCheese", "PizzaCrust", "PizzaDescription", "PizzaSauce" },
                values: new object[] { 2, "The Ray Charles", 14.50m, "Mozzarella", "Traditional", "It'll put Georgia on your mind!", "Garlic Alfredo" });
        }
    }
}
