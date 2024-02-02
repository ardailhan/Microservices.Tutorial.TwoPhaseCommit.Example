using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("08b5df2d-854f-4910-9764-b5d28484940e"), "Stock.API" },
                    { new Guid("7b82a009-3695-4e77-b87e-b61bac121363"), "Payment.API" },
                    { new Guid("d16a7ea7-cbbf-4a26-a101-6eeabe7f7176"), "Order.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("08b5df2d-854f-4910-9764-b5d28484940e"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("7b82a009-3695-4e77-b87e-b61bac121363"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("d16a7ea7-cbbf-4a26-a101-6eeabe7f7176"));
        }
    }
}
