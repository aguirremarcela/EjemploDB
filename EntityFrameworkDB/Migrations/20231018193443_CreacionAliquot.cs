using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkDB.Migrations
{
    /// <inheritdoc />
    public partial class CreacionAliquot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aliquot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Percentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aliquot", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aliquot");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 17, 15, 44, 46, 419, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 10, 17, 15, 44, 46, 419, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2023, 10, 17, 15, 44, 46, 419, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 10, 17, 15, 44, 46, 419, DateTimeKind.Local).AddTicks(4964) });
        }
    }
}
