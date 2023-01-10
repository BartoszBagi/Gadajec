using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gadajec.Persistance.Migrations
{
    public partial class Contacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_AspNetUsers_ApiUserId",
                schema: "Gadajec",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                schema: "Gadajec",
                table: "Contact");

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

            migrationBuilder.RenameTable(
                name: "Contact",
                schema: "Gadajec",
                newName: "Contacts",
                newSchema: "Gadajec");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "Gadajec",
                table: "Contacts",
                newName: "ContactLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "Gadajec",
                table: "Contacts",
                newName: "ContactFirstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "Gadajec",
                table: "Contacts",
                newName: "ContactEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_ApiUserId",
                schema: "Gadajec",
                table: "Contacts",
                newName: "IX_Contacts_ApiUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                schema: "Gadajec",
                table: "Contacts",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("8e8d6356-c56f-4404-860f-f3b756a6b28e"), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój skierowany dla osób pracujących w środowisku C# .Net", ".Net - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("ae6b6fb2-dc1e-4643-b252-e0bb0f2e70eb"), new DateTime(2023, 1, 9, 18, 3, 26, 30, DateTimeKind.Local).AddTicks(8203), "Admin", "Tutaj porozmawiamy o SQL", "SQL - devs" });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name" },
                values: new object[] { new Guid("b2d6254a-bf96-42f7-a85c-8139095b263d"), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "Pokój główny", "MainChat" });

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_ApiUserId",
                schema: "Gadajec",
                table: "Contacts",
                column: "ApiUserId",
                principalSchema: "Gadajec",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_ApiUserId",
                schema: "Gadajec",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                schema: "Gadajec",
                table: "Contacts");

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8e8d6356-c56f-4404-860f-f3b756a6b28e"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ae6b6fb2-dc1e-4643-b252-e0bb0f2e70eb"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b2d6254a-bf96-42f7-a85c-8139095b263d"));

            migrationBuilder.RenameTable(
                name: "Contacts",
                schema: "Gadajec",
                newName: "Contact",
                newSchema: "Gadajec");

            migrationBuilder.RenameColumn(
                name: "ContactLastName",
                schema: "Gadajec",
                table: "Contact",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "ContactFirstName",
                schema: "Gadajec",
                table: "Contact",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                schema: "Gadajec",
                table: "Contact",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_ApiUserId",
                schema: "Gadajec",
                table: "Contact",
                newName: "IX_Contact_ApiUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                schema: "Gadajec",
                table: "Contact",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_AspNetUsers_ApiUserId",
                schema: "Gadajec",
                table: "Contact",
                column: "ApiUserId",
                principalSchema: "Gadajec",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
