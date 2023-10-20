using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 19, 11, 49, 9, 715, DateTimeKind.Local).AddTicks(3475), new DateTime(2023, 10, 19, 11, 49, 9, 715, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 19, 11, 49, 9, 715, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 10, 19, 11, 49, 9, 715, DateTimeKind.Local).AddTicks(3491) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 19, 8, 0, 43, 885, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 10, 19, 8, 0, 43, 885, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 19, 8, 0, 43, 885, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 10, 19, 8, 0, 43, 885, DateTimeKind.Local).AddTicks(7724) });
        }
    }
}
