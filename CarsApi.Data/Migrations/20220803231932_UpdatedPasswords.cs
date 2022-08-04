using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsApi.Data.Migrations
{
    public partial class UpdatedPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "! capital of california is Sacramento #");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "? california is in the pst time zone /");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "abcdefgh");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "abcdefgh");
        }
    }
}
