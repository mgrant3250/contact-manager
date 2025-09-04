using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 3, 6, 10, 14, 25, 185, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 3, 6, 10, 14, 25, 185, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 3, 6, 10, 14, 25, 185, DateTimeKind.Local).AddTicks(3357));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 2, 23, 10, 45, 32, 720, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 2, 23, 10, 45, 32, 720, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 2, 23, 10, 45, 32, 720, DateTimeKind.Local).AddTicks(1549));
        }
    }
}
