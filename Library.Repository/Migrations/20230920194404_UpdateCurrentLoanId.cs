using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCurrentLoanId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurentLoanId",
                table: "Books",
                newName: "CurrentLoanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentLoanId",
                table: "Books",
                newName: "CurentLoanId");
        }
    }
}
