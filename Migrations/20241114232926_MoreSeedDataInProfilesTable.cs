using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conecta.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedDataInProfilesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "user_id", "biography", "image_url", "other_details" },
                values: new object[] { 2, "Naci en Chicago en el 2000", null, "Quiero estudiar Inteligencia artificial" });

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 18, 29, 25, 30, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 18, 29, 25, 32, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 29, 25, 395, DateTimeKind.Local).AddTicks(5210), "$2a$11$zlZybQ6ir.BMm60A55M6ceNOvG7lMNi84LMg6NOMuCa6JaBz2/vui" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 29, 25, 573, DateTimeKind.Local).AddTicks(8886), "$2a$11$ZXbYi0i6BYU6Czy0BoG/guJg.MUPNrWaJwV9QQKhk3RcKqX9Pf3h6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "profiles",
                keyColumn: "user_id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 1,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 18, 25, 48, 69, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "role",
                keyColumn: "id",
                keyValue: 2,
                column: "creation_date",
                value: new DateTime(2024, 11, 14, 18, 25, 48, 71, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 25, 48, 477, DateTimeKind.Local).AddTicks(7577), "$2a$11$7HxUDKuaKByK3mOJONhw5OVL3kQTh6AYiePylof93D1DIxlicy1uG" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 18, 25, 48, 663, DateTimeKind.Local).AddTicks(6979), "$2a$11$/2umaGTb0SkfH51OAhbKB.6hw5H7tkjUTqHOX8NK7DBUN0X8OfXt2" });
        }
    }
}
