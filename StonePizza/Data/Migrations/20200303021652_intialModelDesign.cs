using Microsoft.EntityFrameworkCore.Migrations;

namespace StonePizza.Data.Migrations
{
    public partial class intialModelDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beverages",
                columns: table => new
                {
                    BeverageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    BeverageDescription = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverages", x => x.BeverageId);
                });

            migrationBuilder.CreateTable(
                name: "CustomPizzas",
                columns: table => new
                {
                    CustomPizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<decimal>(nullable: false),
                    PizzaSauce = table.Column<string>(nullable: true),
                    PizzaCrust = table.Column<string>(nullable: true),
                    PizzaCheese = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizzas", x => x.CustomPizzaId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOnOrder = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "SideDishes",
                columns: table => new
                {
                    SideDishId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    SideDishDescription = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideDishes", x => x.SideDishId);
                });

            migrationBuilder.CreateTable(
                name: "SignaturePizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    PizzaDescription = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<decimal>(nullable: false),
                    PizzaSauce = table.Column<string>(nullable: true),
                    PizzaCrust = table.Column<string>(nullable: true),
                    PizzaCheese = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignaturePizzas", x => x.PizzaId);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ToppingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToppingName = table.Column<string>(nullable: true),
                    CustomPizzaId = table.Column<int>(nullable: true),
                    SignaturePizzaPizzaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ToppingId);
                    table.ForeignKey(
                        name: "FK_Toppings_CustomPizzas_CustomPizzaId",
                        column: x => x.CustomPizzaId,
                        principalTable: "CustomPizzas",
                        principalColumn: "CustomPizzaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Toppings_SignaturePizzas_SignaturePizzaPizzaId",
                        column: x => x.SignaturePizzaPizzaId,
                        principalTable: "SignaturePizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_CustomPizzaId",
                table: "Toppings",
                column: "CustomPizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_SignaturePizzaPizzaId",
                table: "Toppings",
                column: "SignaturePizzaPizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beverages");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SideDishes");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "CustomPizzas");

            migrationBuilder.DropTable(
                name: "SignaturePizzas");
        }
    }
}
