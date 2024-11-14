using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conecta.Migrations
{
    /// <inheritdoc />
    public partial class SeederAboutNewUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 12, 5, 38, 438, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 12, 5, 38, 457, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 5, 38, 667, DateTimeKind.Local).AddTicks(4120), "$2a$11$6M9qKL7z81FpS2Ewztpm8eqHiVyXEXvWRXh1ZaXYSPDjcorvkOCq6" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "creation_date", "email", "name", "password", "role_id", "update_date" },
                values: new object[] { 2, new DateTime(2024, 11, 14, 12, 5, 38, 783, DateTimeKind.Local).AddTicks(1556), "user@example.com", "Test", "$2a$11$7TmnpjbInndm7RDgPHVP7eQZFAnptwok0KjWM1mDOMiAg4DO31lN2", 2, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 8, 8, 23, 940, DateTimeKind.Local).AddTicks(7683), "$2a$11$Luaj8bDf5cq9XrMblICtK.UQZUxEbdR3EzSfLTX8.fCTgNFafhkOu" });
        }
    }
}
