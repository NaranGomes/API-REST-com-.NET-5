using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustoidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "cc4b92ec-9023-446d-9a58-96dbc81083cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "34b9aca1-f6db-42f3-8c1e-14db0a4c9973");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dad4f34-d285-4c71-ac50-eda785c72861", "AQAAAAEAACcQAAAAEMqgmPYWLB72cNr82DoHhQ3NBf0hL3S8qHQek3MxRKL/23JHYm8x9N0pPKAE23mR5A==", "708af786-ef5d-4a55-bcd0-aca947b52e81" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "a298be7c-0453-4cd9-951b-21d8d6773992");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "0f5079c5-3337-4a07-b207-b0f96cc43705");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c48c2aef-96bb-4ec7-9b00-c3ca339e63a6", "AQAAAAEAACcQAAAAECyCAT6NVzGhutPby17+ZPGY73PA8f8oe8OQ8MWsg2h9dJF00NH1JADG7JNKrKgF6Q==", "72b32389-403a-4e58-a3aa-2935c6038685" });
        }
    }
}
