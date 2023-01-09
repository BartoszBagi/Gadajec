using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class Contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApiUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_AspNetUsers_ApiUserId",
                        column: x => x.ApiUserId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("3754ac17-715f-484a-b8d6-3bcee104e2de"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój główny", "MainChat" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("90a1ebf2-22ce-4558-8e70-c178e4e7ffef"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", ".Net - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("ec2d852e-463b-4283-a21c-bcc7ab474449"), new DateTime(2023, 1, 6, 17, 58, 11, 991, DateTimeKind.Local).AddTicks(2585), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ApiUserId",
                schema: "Gadajec",
                table: "Contact",
                column: "ApiUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact",
                schema: "Gadajec");

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3754ac17-715f-484a-b8d6-3bcee104e2de"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("90a1ebf2-22ce-4558-8e70-c178e4e7ffef"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ec2d852e-463b-4283-a21c-bcc7ab474449"));

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
    }
}
