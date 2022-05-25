using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5d6684d-947f-4f90-b78e-c3c28c5ca297", "684ed81c-afa3-450a-9498-2cf6c12def4b", "Administrator", "ADMINISTRATOR" },
                    { "a5e5684d-947f-4f90-e88e-c3c28c5ca296", "4b5d9047-4f9d-4a93-9963-b02b57aed3bc", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7713e334-7817-47b1-b1cc-11f37a47a56b", 0, "55a32189-c1b0-4099-8965-4b90e11e9bda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAELu+v4N1UV6XXGGap//qOhRDrABn1iWR0vXhivW2fbURImqJvbIagBHTMdSy5SaHUg==", null, false, "06cda22b-55ed-470e-be0b-549d35f441ff", null, false, null },
                    { "a9d6684d-947f-4f90-b78e-c3c28c5ca297", 0, "716a3643-f915-457b-9d68-a2eab919d026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "", "", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEC+rAk45wLfqfj9J+dTgKeoEfJbg1BLgq1I13uhXFbPAWHxhyzox81IHgczUtmYlwg==", null, false, "23c661e8-714f-43d3-ab41-b4d56a6070f5", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5d6684d-947f-4f90-b78e-c3c28c5ca297", "7713e334-7817-47b1-b1cc-11f37a47a56b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a5e5684d-947f-4f90-e88e-c3c28c5ca296", "a9d6684d-947f-4f90-b78e-c3c28c5ca297" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5d6684d-947f-4f90-b78e-c3c28c5ca297", "7713e334-7817-47b1-b1cc-11f37a47a56b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5e5684d-947f-4f90-e88e-c3c28c5ca296", "a9d6684d-947f-4f90-b78e-c3c28c5ca297" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297");
        }
    }
}
