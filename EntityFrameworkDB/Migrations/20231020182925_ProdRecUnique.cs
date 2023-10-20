using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class ProdRecUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdProduct",
                table: "Receipt_Details");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6804), new DateTime(2023, 10, 20, 15, 29, 25, 631, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdProduct",
                table: "Receipt_Details",
                column: "IdProduct",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details",
                column: "IdReceipt",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdProduct",
                table: "Receipt_Details");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details");

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

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdProduct",
                table: "Receipt_Details",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details",
                column: "IdReceipt");
        }
    }
}
