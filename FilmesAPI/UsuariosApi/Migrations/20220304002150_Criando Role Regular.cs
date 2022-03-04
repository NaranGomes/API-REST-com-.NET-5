using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class CriandoRoleRegular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0f5079c5-3337-4a07-b207-b0f96cc43705");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "a298be7c-0453-4cd9-951b-21d8d6773992", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c48c2aef-96bb-4ec7-9b00-c3ca339e63a6", "AQAAAAEAACcQAAAAECyCAT6NVzGhutPby17+ZPGY73PA8f8oe8OQ8MWsg2h9dJF00NH1JADG7JNKrKgF6Q==", "72b32389-403a-4e58-a3aa-2935c6038685" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "cbc2467a-d3d8-4479-a4f4-252e66a94dd5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf51d8a6-a7cd-4b18-a919-5cb98bd56d84", "AQAAAAEAACcQAAAAEN4fvX+RknTFex9B2clgXblKqaSN9r+5qZwAKjTn/TYNdsQMh3YHwHkwg+NKiAKOPg==", "80eb9b47-54b2-41f8-b828-daafc4d1ad61" });
        }
    }
}
