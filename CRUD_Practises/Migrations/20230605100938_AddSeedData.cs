using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Practises.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Price", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { "P001", "3C", 45000m, "Iphone 14", 23 },
                    { "P015", "食品", 45m, "台酒花雕雞泡麵(袋裝)", 250000 },
                    { "P014", "食品", 53m, "台酒花雕雞泡麵(碗裝)", 10000 },
                    { "P013", "飲料", 25m, "紅茶(瓶裝)", 1230 },
                    { "P012", "飲料", 20m, "錫蘭奶茶(瓶裝)", 5000 },
                    { "P011", "飲料", 35m, "烏龍茶(瓶裝)", 10000 },
                    { "P010", "食品", 53m, "滿漢大餐珍味牛肉麵(碗裝)", 25080 },
                    { "P016", "3C", 53420m, "Ipad Pro", 1000 },
                    { "P009", "食品", 53m, "台酒酸菜牛肉泡麵(碗裝)", 12000 },
                    { "P007", "食品", 53m, "台酒麻油雞泡麵(碗裝)", 5000 },
                    { "P006", "食品", 50m, "辛拉麵(袋裝)", 1000 },
                    { "P005", "飲料", 25m, "綠茶(瓶裝)", 1000 },
                    { "P004", "飲料", 370m, "青森頻果原汁", 100 },
                    { "P003", "3C", 35200m, "SamSung S20", 15 },
                    { "P002", "3C", 23000m, "SamSung A52", 10 },
                    { "P008", "食品", 53m, "台酒花雕雞泡麵(碗裝)", 10000 },
                    { "P017", "3C", 33023m, "筆記型電腦", 1235 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P003");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P004");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P005");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P006");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P007");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P008");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P009");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P010");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P011");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P012");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P013");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P014");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P015");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P016");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "P017");
        }
    }
}
