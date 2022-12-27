using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class updateRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("07b17359-20e0-4cac-8366-a9f7b37d564e"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a477c367-042e-4a04-98ec-f0807741d190"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Gadajec",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Gadajec",
                table: "Rooms");

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("07b17359-20e0-4cac-8366-a9f7b37d564e"), new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("a477c367-042e-4a04-98ec-f0807741d190"), new DateTime(2022, 12, 4, 21, 1, 6, 381, DateTimeKind.Local).AddTicks(7561), "Admin", "SQL - devs" });
        }
    }
}
