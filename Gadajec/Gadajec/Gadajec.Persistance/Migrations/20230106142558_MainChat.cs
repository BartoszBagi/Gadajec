using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class MainChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("5598fc8b-303c-400a-9624-8cf37a7d9c07"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój główny", "MainChat" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("93e6d5a3-bbc4-4943-a7cf-1b1d164e1788"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", ".Net - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("f128f374-e236-4cf0-b8a2-228266b7e58a"), new DateTime(2023, 1, 6, 15, 25, 57, 890, DateTimeKind.Local).AddTicks(6865), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5598fc8b-303c-400a-9624-8cf37a7d9c07"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("93e6d5a3-bbc4-4943-a7cf-1b1d164e1788"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f128f374-e236-4cf0-b8a2-228266b7e58a"));

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
    }
}
