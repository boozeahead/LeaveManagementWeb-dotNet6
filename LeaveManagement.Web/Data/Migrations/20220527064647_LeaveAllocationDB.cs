using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveAllocationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "period",
                table: "LeaveAllocations",
                newName: "Period");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Period",
                table: "LeaveAllocations",
                newName: "period");

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
    }
}
