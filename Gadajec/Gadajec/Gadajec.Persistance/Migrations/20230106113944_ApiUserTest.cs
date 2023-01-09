using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class ApiUserTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("29d0c0af-6240-47e1-ba12-fc5f428013a8"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f3781763-351b-4570-b5e3-1e31fb7f2e36"));

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("20ecbaaf-4918-4afe-b8d6-d6d3c579f8d6"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", ".Net - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("2b75273f-761b-4657-b3b3-affc8695787b"), new DateTime(2023, 1, 6, 12, 39, 43, 749, DateTimeKind.Local).AddTicks(9487), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("20ecbaaf-4918-4afe-b8d6-d6d3c579f8d6"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2b75273f-761b-4657-b3b3-affc8695787b"));

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("29d0c0af-6240-47e1-ba12-fc5f428013a8"), new DateTime(2023, 1, 2, 18, 55, 19, 726, DateTimeKind.Local).AddTicks(6803), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("f3781763-351b-4570-b5e3-1e31fb7f2e36"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", ".Net - devs" });
        }
    }
}
