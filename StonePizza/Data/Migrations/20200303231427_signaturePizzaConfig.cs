using Microsoft.EntityFrameworkCore.Migrations;

namespace StonePizza.Data.Migrations
{
    public partial class signaturePizzaConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_SignaturePizzas_SignaturePizzaPizzaId",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_SignaturePizzaPizzaId",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "SignaturePizzaPizzaId",
                table: "Toppings");

            migrationBuilder.InsertData(
                table: "SignaturePizzas",
                columns: new[] { "PizzaId", "ItemName", "ItemPrice", "PizzaCheese", "PizzaCrust", "PizzaDescription", "PizzaSauce" },
                values: new object[] { 1, "The James Brown", 14.00m, "Mozzarella", "Traditional", "Makes you want to dance!", "Traditional" });

            migrationBuilder.InsertData(
                table: "SignaturePizzas",
                columns: new[] { "PizzaId", "ItemName", "ItemPrice", "PizzaCheese", "PizzaCrust", "PizzaDescription", "PizzaSauce" },
                values: new object[] { 2, "The Ray Charles", 14.50m, "Mozzarella", "Traditional", "It'll put Georgia on your mind!", "Garlic Alfredo" });

            migrationBuilder.InsertData(
                table: "SignaturePizzas",
                columns: new[] { "PizzaId", "ItemName", "ItemPrice", "PizzaCheese", "PizzaCrust", "PizzaDescription", "PizzaSauce" },
                values: new object[] { 3, "The Stevie Wonder", 16.50m, "Vegan Cheese", "Gluten-free", "It'll make you superstitious!", "Traditional" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SignaturePizzas",
                keyColumn: "PizzaId",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "SignaturePizzaPizzaId",
                table: "Toppings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_SignaturePizzaPizzaId",
                table: "Toppings",
                column: "SignaturePizzaPizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_SignaturePizzas_SignaturePizzaPizzaId",
                table: "Toppings",
                column: "SignaturePizzaPizzaId",
                principalTable: "SignaturePizzas",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
