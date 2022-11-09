using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gadajec.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6013a924-85d9-405d-8f0e-86391f89b64b"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6213b149-c6df-41e4-a6a7-5636f50a5e63"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72e2e9a6-7a14-4695-8312-aeabb9138f6f"));

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("553a4c81-af34-4246-bd58-173c6a9def94"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" },
                    { new Guid("75454259-dfd5-40c1-b5b3-829581e572f8"), new DateTime(2022, 11, 9, 17, 34, 8, 206, DateTimeKind.Local).AddTicks(2192), "Admin", "SQL - devs" }
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("b8a6394f-160f-4e5f-804f-c8662cadeda8"), new DateTime(2022, 11, 9, 17, 34, 8, 206, DateTimeKind.Local).AddTicks(2010), "Bartosz@mail.com.pl", "Bartosz", "Bagiński", "SGFzbG8=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("553a4c81-af34-4246-bd58-173c6a9def94"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("75454259-dfd5-40c1-b5b3-829581e572f8"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8a6394f-160f-4e5f-804f-c8662cadeda8"));

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("6013a924-85d9-405d-8f0e-86391f89b64b"), new DateTime(2022, 11, 8, 18, 26, 19, 557, DateTimeKind.Local).AddTicks(3671), "Admin", "SQL - devs" },
                    { new Guid("6213b149-c6df-41e4-a6a7-5636f50a5e63"), new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" }
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("72e2e9a6-7a14-4695-8312-aeabb9138f6f"), new DateTime(2022, 11, 8, 18, 26, 19, 557, DateTimeKind.Local).AddTicks(3330), "Bartosz@mail.com.pl", "Bartosz", "Bagiński", "SGFzbG8=" });
        }
    }
}
