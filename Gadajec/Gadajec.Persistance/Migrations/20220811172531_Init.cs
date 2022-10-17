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
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
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
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomUser",
                schema: "Gadajec",
                columns: table => new
                {
                    RoomsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomUser", x => new { x.RoomsID, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoomUser_Rooms_RoomsID",
                        column: x => x.RoomsID,
                        principalSchema: "Gadajec",
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "Gadajec",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("1ec00894-b394-4059-84bf-01d6b11b67a0"), null, "Admin", "C# - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("420cc0c3-53f7-4cba-8e55-0350c6d1f159"), null, "Admin", "SQL - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Users",
                columns: new[] { "Id", "ContactId", "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("86791339-8587-4014-9d28-601a69dc9fd0"), 0, new DateTime(2022, 8, 11, 19, 25, 31, 423, DateTimeKind.Local).AddTicks(559), "Bartosz@mail.com.pl", "Bartosz", "Bagiński", "SGFzbG8=" });

            migrationBuilder.CreateIndex(
                name: "IX_RoomUser_UsersId",
                schema: "Gadajec",
                table: "RoomUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomUser",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "Rooms",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Gadajec");
        }
    }
}
