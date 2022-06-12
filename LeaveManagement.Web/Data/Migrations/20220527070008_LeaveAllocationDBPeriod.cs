using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveAllocationDBPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                column: "ConcurrencyStamp",
                value: "97fe9968-0e24-4ea6-94b3-d03c17986957");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                column: "ConcurrencyStamp",
                value: "3a4ab9b8-2e2c-4a8f-ba56-73dcb5570ca5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "967815ec-614d-4d8d-9526-f2c4f38223a0", "AQAAAAEAACcQAAAAEIoqTDxrsYJHJZMbQh/yRXOdACeO3hZ6hXQyayS31vfGobFEdHrAXP1DGI4sW8x4PA==", "a0d7dd84-759e-4995-9917-dcccbc8b39ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd027dce-7bd0-481f-bcd4-149b2374483d", "AQAAAAEAACcQAAAAEHf1ylnKuB7B+j7c6psZvFN9rd+/YFqgbGgprk16smn5d9Ed4Huqw9KWmqYxOSI9Hw==", "8d7e3b75-eaab-499a-a9b8-d060247d68f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
