using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Gadajec");

            migrationBuilder.CreateTable(
                name: "Rooms",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "Gadajec",
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("c01e5e06-c53e-43dc-8269-5a21ef12ab98"), new DateTime(2022, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("f72e7da3-cabd-411e-b1c0-7facac7ea9d5"), new DateTime(2022, 10, 17, 18, 46, 9, 426, DateTimeKind.Local).AddTicks(151), "Admin", "SQL - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "RoomId" },
                values: new object[] { new Guid("0490123f-7b59-4eb0-818c-89fae4fb8d75"), new DateTime(2022, 10, 17, 18, 46, 9, 425, DateTimeKind.Local).AddTicks(9970), "Bartosz@mail.com.pl", "Bartosz", "Bagiński", "SGFzbG8=", null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoomId",
                schema: "Gadajec",
                table: "Users",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "Rooms",
                schema: "Gadajec");
        }
    }
}
