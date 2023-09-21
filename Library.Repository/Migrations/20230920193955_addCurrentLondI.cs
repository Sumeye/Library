using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addCurrentLondI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurentLoanId",
                table: "Books",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurentLoanId",
                table: "Books");
        }
    }
}
