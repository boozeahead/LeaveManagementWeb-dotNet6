using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                column: "ConcurrencyStamp",
                value: "dcddf81c-e059-467e-bde5-79515ff4cca5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                column: "ConcurrencyStamp",
                value: "7fe3402b-8be3-4b35-aa4f-517da5f02fc1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "357f906e-b35f-493f-990d-c7cc13f25b57", "AQAAAAEAACcQAAAAENy1djQyyBrfKlNj9/5TpdjHrSUXAVeTpcjD/ATPIri3TIEFXKYU7uBZ9MicSjMsRA==", "5a097d53-b935-4322-9ede-0bc8122c2cec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "003cf4ff-7043-40f3-b808-542602117a95", "AQAAAAEAACcQAAAAELxAQ9b6JBzbzIJ2BPNu5i4h4X5rfT9emfMKUuFkink/2i2IWJZapU8h1pZqKNt0qg==", "1ae39c8b-c8a5-435c-b9a4-c644d9dc209b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                column: "ConcurrencyStamp",
                value: "66fa7906-848e-4a9f-8ff4-0c3dd3f424ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                column: "ConcurrencyStamp",
                value: "7cb73c31-1ed2-40f8-af95-c0e5ed870dfc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b18bb2f-b7c6-427b-a579-82225f293ec1", "AQAAAAEAACcQAAAAEFxNoSTYkE575srIRPhkTozTr+cNihOc0KNE8LHXjsJRb/C7h1cVLIDq4lxR/fjn0A==", "7ff604b9-525b-493a-b4a7-d292b56385b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b9353a6-b0f5-4370-a1e1-df1628ee6a0a", "AQAAAAEAACcQAAAAEDAgWt9qiwH60X1/sjZgB6qo5ccaxvCs2uXWZXBueJeqR47/YiWOzJGO9sMJWxZfkA==", "872e1eba-dae7-4b25-8fdd-c46e9ae4b120" });
        }
    }
}
