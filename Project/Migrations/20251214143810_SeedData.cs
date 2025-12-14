using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "TransactionId", "Amount", "Description", "TransactionDate", "TransactionType" },
                values: new object[,]
                {
                    { 1, 100m, "System", new DateTime(2025, 12, 14, 22, 38, 9, 685, DateTimeKind.Local).AddTicks(7265), "dinner" },
                    { 2, 500m, "System", new DateTime(2025, 12, 14, 22, 38, 9, 685, DateTimeKind.Local).AddTicks(7277), "lunch" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "TransactionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transaction",
                keyColumn: "TransactionId",
                keyValue: 2);
        }
    }
}
