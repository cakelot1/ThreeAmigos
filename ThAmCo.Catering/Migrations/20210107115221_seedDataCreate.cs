using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Catering.Migrations
{
    public partial class seedDataCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPice",
                table: "FoodItems",
                newName: "UnitPrice");

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "Description", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Tomato Soup", 4f },
                    { 2, "French Onion Soup", 3.5f },
                    { 3, "Leak & Onion Soup", 3.75f },
                    { 4, "White bread bun", 0.75f },
                    { 5, "Wholemeal bun", 0.75f }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "MenuName" },
                values: new object[,]
                {
                    { 1, "French Classic" },
                    { 2, "Chef's Soup" }
                });

            migrationBuilder.InsertData(
                table: "MenuFoodItems",
                columns: new[] { "MenuId", "FoodItemId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "foodBookings",
                columns: new[] { "FoodBookingId", "ClientReference", "MenuId", "NumberOfGuests" },
                values: new object[,]
                {
                    { 1, 1, 1, 15 },
                    { 2, 2, 2, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuFoodItems",
                keyColumns: new[] { "MenuId", "FoodItemId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MenuFoodItems",
                keyColumns: new[] { "MenuId", "FoodItemId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "MenuFoodItems",
                keyColumns: new[] { "MenuId", "FoodItemId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MenuFoodItems",
                keyColumns: new[] { "MenuId", "FoodItemId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "foodBookings",
                keyColumn: "FoodBookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "foodBookings",
                keyColumn: "FoodBookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "FoodItems",
                newName: "UnitPice");
        }
    }
}
