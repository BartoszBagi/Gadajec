using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class RoomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Rooms_RoomId",
                schema: "Gadajec",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoomId",
                schema: "Gadajec",
                table: "Users");

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c01e5e06-c53e-43dc-8269-5a21ef12ab98"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f72e7da3-cabd-411e-b1c0-7facac7ea9d5"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0490123f-7b59-4eb0-818c-89fae4fb8d75"));

            migrationBuilder.DropColumn(
                name: "RoomId",
                schema: "Gadajec",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "RoomUser",
                schema: "Gadajec",
                columns: table => new
                {
                    RoomsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomUser", x => new { x.RoomsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoomUser_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalSchema: "Gadajec",
                        principalTable: "Rooms",
                        principalColumn: "Id",
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
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("e67b0cac-fea2-4a45-af7d-c3bd8c7c0229"), new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[] { new Guid("f3efa56f-eb63-4d98-9200-e4af189bebd2"), new DateTime(2022, 10, 19, 19, 44, 53, 755, DateTimeKind.Local).AddTicks(7023), "Admin", "SQL - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("25b4e618-b690-4c3d-8034-c90ca11fa790"), new DateTime(2022, 10, 19, 19, 44, 53, 755, DateTimeKind.Local).AddTicks(6848), "Bartosz@mail.com.pl", "Bartosz", "Bagiński", "SGFzbG8=" });

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

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e67b0cac-fea2-4a45-af7d-c3bd8c7c0229"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f3efa56f-eb63-4d98-9200-e4af189bebd2"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25b4e618-b690-4c3d-8034-c90ca11fa790"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                schema: "Gadajec",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Rooms_RoomId",
                schema: "Gadajec",
                table: "Users",
                column: "RoomId",
                principalSchema: "Gadajec",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
