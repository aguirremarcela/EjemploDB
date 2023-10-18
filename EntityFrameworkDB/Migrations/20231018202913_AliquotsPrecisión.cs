using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class AliquotsPrecisión : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Percentaje",
                table: "Aliquot",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 29, 12, 920, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 10, 18, 17, 29, 12, 920, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 18, 17, 29, 12, 920, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 10, 18, 17, 29, 12, 920, DateTimeKind.Local).AddTicks(9934) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Percentaje",
                table: "Aliquot",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 34, 43, 547, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 10, 18, 16, 34, 43, 547, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 34, 43, 547, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 10, 18, 16, 34, 43, 547, DateTimeKind.Local).AddTicks(9879) });
        }
    }
}
