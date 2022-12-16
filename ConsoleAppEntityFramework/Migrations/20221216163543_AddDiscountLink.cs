using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrderID",
                table: "Discounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_OrderID",
                table: "Discounts",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_Orders_OrderID",
                table: "Discounts",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_Orders_OrderID",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_OrderID",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Discounts");
        }
    }
}
