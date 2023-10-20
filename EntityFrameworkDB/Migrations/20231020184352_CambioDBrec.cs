using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class CambioDBrec : Migration
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
                values: new object[] { new DateTime(2023, 10, 20, 15, 43, 52, 534, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 10, 20, 15, 43, 52, 534, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 43, 52, 534, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 10, 20, 15, 43, 52, 534, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdProduct_IdReceipt",
                table: "Receipt_Details",
                columns: new[] { "IdProduct", "IdReceipt" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details",
                column: "IdReceipt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdProduct_IdReceipt",
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
    }
}
