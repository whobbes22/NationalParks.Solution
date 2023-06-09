using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParkDescription",
                table: "Parks",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ParkLocation",
                table: "Parks",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ParkName",
                table: "Parks",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ParkSize",
                table: "Parks",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ParkType",
                table: "Parks",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "ParkDescription", "ParkLocation", "ParkName", "ParkSize", "ParkType" },
                values: new object[] { "a Massive park", "Wyoming", "Yellowstone", "2.2 million acres", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "ParkDescription", "ParkLocation", "ParkName", "ParkSize", "ParkType" },
                values: new object[,]
                {
                    { 2, "A lot of really tall trees", "California", "Sequoia and Kings Canyon", "1353 square miles", "National" },
                    { 3, "Awesome rock formations", "Nevada", "Valley of Fire", "40,000 acres", "State" },
                    { 4, "A good place to Hike with a fantastic waterfall at the end.", "West Virginia", "Blackwater Falls", "2,358 acres", "State" },
                    { 5, "The biggest water park in the United States!", "Wisconsin", "Noah's Ark", "70 acres", "Water Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ParkLocation",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "ParkName",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "ParkSize",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "ParkType",
                table: "Parks");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkDescription",
                keyValue: null,
                column: "ParkDescription",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ParkDescription",
                table: "Parks",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "ParkDescription",
                value: "a good place to visit");
        }
    }
}
