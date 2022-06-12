using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveAllocationPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                column: "ConcurrencyStamp",
                value: "229a3880-cd94-450e-ba49-c68bd0ba514b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                column: "ConcurrencyStamp",
                value: "f9e02baa-6013-4505-b10c-15433e893be4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2b3e5e5-508e-4251-b2c1-8e4f931cded7", "AQAAAAEAACcQAAAAEJzJnjxsUzL2Y5iYgtFUn1uRpIXN9YbDYbGmdzO0nPi0qvnT4ZcGz16Jqmpz0ipnxw==", "377e917e-e032-4388-a17d-f2d8f18462d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "110c8aa0-7be4-4928-9aa8-a38e83635f19", "AQAAAAEAACcQAAAAEHtNyD7WbYH7WLGYxXB4A94hqWep1xaTj38I6b3BCUdyPeoqr5qhWaCqkaA89BjSNw==", "30beddad-7376-49b7-89c6-3060e9a638d0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                column: "ConcurrencyStamp",
                value: "a0c3530c-45b8-46ec-aa07-4f5c012d9663");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                column: "ConcurrencyStamp",
                value: "4895eae1-6053-4a71-a4c9-7b172055be87");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe8eddc9-4781-4894-ae1b-5169c62ae14a", "AQAAAAEAACcQAAAAEN2Nc4Cg51/8wD7o5ob8mvBN/AhvTwien2ihlgeeS/4r1Er0MOlUt9wVym9Hi3xQiQ==", "2e62bee6-2372-464f-bb3d-96b707b8d640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a006329a-6619-414c-8c9e-dfc012761316", "AQAAAAEAACcQAAAAEANCFSp7MqnWdm4wTGReOgXM7jK7i4wCqrX5jPVk9jHhkqhuJ/15pd1JUaMYhZdzDQ==", "fbdf04ca-03cf-473c-b8ca-c13d295baeac" });
        }
    }
}
