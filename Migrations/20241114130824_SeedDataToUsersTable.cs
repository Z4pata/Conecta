using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conecta.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 8, 8, 23, 739, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 8, 8, 23, 759, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "creation_date", "email", "name", "password", "role_id", "update_date" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 8, 8, 23, 940, DateTimeKind.Local).AddTicks(7683), "zapata.devs@gmail.com", "Juan Jose", "$2a$11$Luaj8bDf5cq9XrMblICtK.UQZUxEbdR3EzSfLTX8.fCTgNFafhkOu", 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 7, 55, 37, 31, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 7, 55, 37, 51, DateTimeKind.Local).AddTicks(4182));
        }
    }
}
