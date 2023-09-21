using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Repository.Migrations
{
    /// <inheritdoc />
    public partial class removeLoanStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Loan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Loan",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
