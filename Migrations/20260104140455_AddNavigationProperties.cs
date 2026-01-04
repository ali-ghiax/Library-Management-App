using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BookId",
                table: "Transactions",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MembershipId",
                table: "Transactions",
                column: "MembershipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Books_BookId",
                table: "Transactions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Memberships_MembershipId",
                table: "Transactions",
                column: "MembershipId",
                principalTable: "Memberships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Books_BookId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Memberships_MembershipId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_BookId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_MembershipId",
                table: "Transactions");
        }
    }
}
