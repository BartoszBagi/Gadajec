using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6a98bb42-c925-4e15-a650-ce7bf06173d5"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ead53eca-072e-4751-bd4d-204d388d6df0"));

            migrationBuilder.DropColumn(
                name: "RoomID",
                schema: "Gadajec",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                schema: "Gadajec",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                schema: "Gadajec",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                schema: "Gadajec",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RoomName",
                schema: "Gadajec",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderName",
                schema: "Gadajec",
                table: "Messages");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomID",
                schema: "Gadajec",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SenderId",
                schema: "Gadajec",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("6a98bb42-c925-4e15-a650-ce7bf06173d5"), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", ".Net - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("ead53eca-072e-4751-bd4d-204d388d6df0"), new DateTime(2022, 12, 31, 11, 6, 19, 517, DateTimeKind.Local).AddTicks(1908), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });
        }
    }
}
