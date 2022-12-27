using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("4ddab081-8a66-4ecf-ae75-304458b16c68"), new DateTime(2022, 12, 27, 10, 46, 37, 297, DateTimeKind.Local).AddTicks(3180), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("8742de9d-e91d-42e4-a0c9-18533baeff13"), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", "C# - devs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4ddab081-8a66-4ecf-ae75-304458b16c68"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8742de9d-e91d-42e4-a0c9-18533baeff13"));
        }
    }
}
