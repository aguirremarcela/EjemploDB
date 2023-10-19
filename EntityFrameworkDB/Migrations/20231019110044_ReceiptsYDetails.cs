using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class ReceiptsYDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Aliquot = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Aliquot_Id_Aliquot",
                        column: x => x.Id_Aliquot,
                        principalTable: "Aliquot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipt_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReceipt = table.Column<int>(type: "int", nullable: false),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    Unitprice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    IdReceipts = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipt_Details_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipt_Details_Receipt_IdReceipts",
                        column: x => x.IdReceipts,
                        principalTable: "Receipt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_Id_Aliquot",
                table: "Product",
                column: "Id_Aliquot");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdProduct",
                table: "Receipt_Details",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_Details_IdReceipts",
                table: "Receipt_Details",
                column: "IdReceipts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt_Details");

            migrationBuilder.DropTable(
                name: "Product");

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
    }
}
