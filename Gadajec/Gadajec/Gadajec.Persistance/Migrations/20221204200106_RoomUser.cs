using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class RoomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2dbd19ce-ed79-43b4-a05b-39f38fd57e2a"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d1d765ef-f867-4416-8efd-08320bb449d9"));

            migrationBuilder.CreateTable(
                name: "ApiUserRoom",
                schema: "Gadajec",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId1 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiUserRoom", x => new { x.UsersId, x.UsersId1 });
                    table.ForeignKey(
                        name: "FK_ApiUserRoom_AspNetUsers_UsersId1",
                        column: x => x.UsersId1,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApiUserRoom_Rooms_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "Gadajec",
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApiUserRoom_UsersId1",
                schema: "Gadajec",
                table: "ApiUserRoom",
                column: "UsersId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiUserRoom",
                schema: "Gadajec");

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

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("2dbd19ce-ed79-43b4-a05b-39f38fd57e2a"), new DateTime(2022, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("d1d765ef-f867-4416-8efd-08320bb449d9"), new DateTime(2022, 11, 30, 17, 59, 47, 38, DateTimeKind.Local).AddTicks(9892), "Admin", "SQL - devs" });
        }
    }
}
