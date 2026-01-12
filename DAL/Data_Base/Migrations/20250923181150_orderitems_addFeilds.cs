using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Data_Base.Migrations
{
    /// <inheritdoc />
    public partial class orderitems_addFeilds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "OrderItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderItems");
        }
    }
}
