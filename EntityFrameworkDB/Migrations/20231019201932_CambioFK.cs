using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class CambioFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Details_Receipt_IdReceipts",
                table: "Receipt_Details");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdReceipts",
                table: "Receipt_Details");

            migrationBuilder.DropColumn(
                name: "IdReceipts",
                table: "Receipt_Details");

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

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details",
                column: "IdReceipt");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Details_Receipt_IdReceipt",
                table: "Receipt_Details",
                column: "IdReceipt",
                principalTable: "Receipt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Details_Receipt_IdReceipt",
                table: "Receipt_Details");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_Details_IdReceipt",
                table: "Receipt_Details");

            migrationBuilder.AddColumn<int>(
                name: "IdReceipts",
                table: "Receipt_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdReceipts",
                table: "Receipt_Details",
                column: "IdReceipts");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Details_Receipt_IdReceipts",
                table: "Receipt_Details",
                column: "IdReceipts",
                principalTable: "Receipt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
