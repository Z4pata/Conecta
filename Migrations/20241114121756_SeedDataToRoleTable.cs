using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Conecta.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "id", "creation_date", "name", "update_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 14, 7, 17, 56, 546, DateTimeKind.Local).AddTicks(7350), "admin", null },
                    { 2, new DateTime(2024, 11, 14, 7, 17, 56, 546, DateTimeKind.Local).AddTicks(7385), "user", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
