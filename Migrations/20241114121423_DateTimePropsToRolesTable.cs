using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conecta.Migrations
{
    /// <inheritdoc />
    public partial class DateTimePropsToRolesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "creation_date",
                table: "role",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "update_date",
                table: "role",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "creation_date",
                table: "role");

            migrationBuilder.DropColumn(
                name: "update_date",
                table: "role");
        }
    }
}
