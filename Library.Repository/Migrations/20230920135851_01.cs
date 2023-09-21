using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_Books_BooksId",
                table: "Loan");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Books_CurrentLoanId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CurrentLoanId",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Loan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_Books_BooksId",
                table: "Loan",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "BooksId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_Books_BooksId",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Loan");

            migrationBuilder.AddColumn<int>(
                name: "CurrentLoanId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Books_CurrentLoanId",
                table: "Books",
                column: "CurrentLoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_Books_BooksId",
                table: "Loan",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "CurrentLoanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
