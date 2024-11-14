using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conecta.Migrations
{
    /// <inheritdoc />
    public partial class ProfilesTableWithSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    image_url = table.Column<string>(type: "TEXT", nullable: true),
                    biography = table.Column<string>(type: "TEXT", nullable: true),
                    other_details = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_profiles_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "user_id", "biography", "image_url", "other_details" },
                values: new object[] { 1, "Naci en bello en el 2007", null, "Quiero estudiar ingenieria de sistemas" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profiles");

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

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "creation_date", "password" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 5, 38, 783, DateTimeKind.Local).AddTicks(1556), "$2a$11$7TmnpjbInndm7RDgPHVP7eQZFAnptwok0KjWM1mDOMiAg4DO31lN2" });
        }
    }
}
