using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class CambioRecDet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 20, 14, 59, 16, 771, DateTimeKind.Local).AddTicks(2038), new DateTime(2023, 10, 20, 14, 59, 16, 771, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 20, 14, 59, 16, 771, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 10, 20, 14, 59, 16, 771, DateTimeKind.Local).AddTicks(2067) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 19, 32, 239, DateTimeKind.Local).AddTicks(5132), new DateTime(2023, 10, 19, 17, 19, 32, 239, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 19, 32, 239, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 10, 19, 17, 19, 32, 239, DateTimeKind.Local).AddTicks(5150) });
        }
    }
}
