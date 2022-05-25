using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2b18bb2f-b7c6-427b-a579-82225f293ec1", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFxNoSTYkE575srIRPhkTozTr+cNihOc0KNE8LHXjsJRb/C7h1cVLIDq4lxR/fjn0A==", "7ff604b9-525b-493a-b4a7-d292b56385b4", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "Firstname", "Lastname", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b9353a6-b0f5-4370-a1e1-df1628ee6a0a", true, "System", "User", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEDAgWt9qiwH60X1/sjZgB6qo5ccaxvCs2uXWZXBueJeqR47/YiWOzJGO9sMJWxZfkA==", "872e1eba-dae7-4b25-8fdd-c46e9ae4b120", "admin@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                column: "ConcurrencyStamp",
                value: "684ed81c-afa3-450a-9498-2cf6c12def4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                column: "ConcurrencyStamp",
                value: "4b5d9047-4f9d-4a93-9963-b02b57aed3bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7713e334-7817-47b1-b1cc-11f37a47a56b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55a32189-c1b0-4099-8965-4b90e11e9bda", false, null, "AQAAAAEAACcQAAAAELu+v4N1UV6XXGGap//qOhRDrABn1iWR0vXhivW2fbURImqJvbIagBHTMdSy5SaHUg==", "06cda22b-55ed-470e-be0b-549d35f441ff", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "Firstname", "Lastname", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "716a3643-f915-457b-9d68-a2eab919d026", false, "", "", null, "AQAAAAEAACcQAAAAEC+rAk45wLfqfj9J+dTgKeoEfJbg1BLgq1I13uhXFbPAWHxhyzox81IHgczUtmYlwg==", "23c661e8-714f-43d3-ab41-b4d56a6070f5", null });
        }
    }
}
