using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gadajec.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitIdentity : Migration
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "Gadajec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "Gadajec",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "Gadajec",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "Gadajec",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Gadajec",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("523c84dd-1142-4377-824c-1cc2fc69b0f6"), new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "C# - devs" },
                    { new Guid("a09ccf7d-c0b8-47be-92aa-79a47df73959"), new DateTime(2022, 11, 9, 17, 55, 40, 663, DateTimeKind.Local).AddTicks(1372), "Admin", "SQL - devs" }
                });

            migrationBuilder.InsertData(
                schema: "Gadajec",
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("4e807fb8-3d32-4f10-bf8b-cfb2012419f9"), new DateTime(2022, 11, 9, 17, 55, 40, 663, DateTimeKind.Local).AddTicks(1124), "Bartosz@mail.com.pl", "Bartosz", "Bagiński", "SGFzbG8=" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Gadajec",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Gadajec",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Gadajec",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Gadajec",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Gadajec",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Gadajec",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Gadajec",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "Gadajec");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "Gadajec");

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("523c84dd-1142-4377-824c-1cc2fc69b0f6"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a09ccf7d-c0b8-47be-92aa-79a47df73959"));

            migrationBuilder.DeleteData(
                schema: "Gadajec",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e807fb8-3d32-4f10-bf8b-cfb2012419f9"));

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
