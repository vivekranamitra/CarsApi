using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsApi.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Make", "Model" },
                values: new object[,]
                {
                    { 1, "Ford", "Bronco" },
                    { 2, "Chevrolet", "Silverado" },
                    { 3, "Toyota", "RAV4" },
                    { 4, "Honda", "Pilot" },
                    { 5, "Mercedez", "Benz" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "John Smith", "! capital of california is Sacramento #", "jsmith@cars.com" },
                    { 2, "Bob Andrews", "? california is in the pst time zone /", "bandrews@cars.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
