using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet_JWT_6.Migrations
{
    public partial class RefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "673a81f0-a82f-4669-83d7-0fb5e0bc1ef0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bb4d77c-f64b-4791-963d-5fa649ce1b7d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0da44b51-b4ae-43c9-9c8f-7208c4cd946e", "3992bdce-77ed-493e-9188-b8e312df41c5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d074114f-1f4d-4e13-95ed-e0fbece32976", "d37be91e-38fc-4164-964b-7311f9742e77", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0da44b51-b4ae-43c9-9c8f-7208c4cd946e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d074114f-1f4d-4e13-95ed-e0fbece32976");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "673a81f0-a82f-4669-83d7-0fb5e0bc1ef0", "5a05af5f-b8c9-4620-b4aa-d731c73b7f5c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9bb4d77c-f64b-4791-963d-5fa649ce1b7d", "ed3888ba-a442-4882-a15a-4ddf5327551b", "User", "USER" });
        }
    }
}
