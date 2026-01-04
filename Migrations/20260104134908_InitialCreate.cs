using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Edition = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    TotalCopies = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MemberType = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    MembershipId = table.Column<int>(type: "INTEGER", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FineAmount = table.Column<decimal>(type: "TEXT", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "Edition", "ISBN", "Name", "TotalCopies" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", "1st", "978-0-7432-7356-5", "The Great Gatsby", 5 },
                    { 2, "Harper Lee", "Fiction", "1st", "978-0-06-112008-4", "To Kill a Mockingbird", 3 },
                    { 3, "George Orwell", "Dystopian", "1st", "978-0-452-28423-4", "1984", 4 },
                    { 4, "Jane Austen", "Romance", "1st", "978-0-14-143951-8", "Pride and Prejudice", 6 },
                    { 5, "J.D. Salinger", "Fiction", "1st", "978-0-316-76948-0", "The Catcher in the Rye", 2 },
                    { 6, "J.K. Rowling", "Fantasy", "1st", "978-0-439-70619-5", "Harry Potter and the Sorcerer's Stone", 7 },
                    { 7, "J.R.R. Tolkien", "Fantasy", "1st", "978-0-547-92822-7", "The Lord of the Rings", 3 },
                    { 8, "Paulo Coelho", "Philosophy", "1st", "978-0-06-112241-5", "The Alchemist", 4 },
                    { 9, "Yuval Noah Harari", "History", "1st", "978-0-06-231609-7", "Sapiens", 5 },
                    { 10, "James Clear", "Self-Help", "1st", "978-0-7352-1129-2", "Atomic Habits", 8 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "DateJoined", "MemberType", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "John Doe", "123-456-7890" },
                    { 2, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teacher", "Jane Smith", "123-456-7891" },
                    { 3, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "Bob Johnson", "123-456-7892" },
                    { 4, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Librarian", "Alice Brown", "123-456-7893" },
                    { 5, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "Charlie Wilson", "123-456-7894" },
                    { 6, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teacher", "Diana Davis", "123-456-7895" },
                    { 7, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "Edward Miller", "123-456-7896" },
                    { 8, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "Fiona Garcia", "123-456-7897" },
                    { 9, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teacher", "George Lee", "123-456-7898" },
                    { 10, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", "Helen Taylor", "123-456-7899" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "BookId", "FineAmount", "IssueDate", "MembershipId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, 0m, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0m, new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 0m, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 0m, new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 0m, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, 0m, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 0m, new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, 0m, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, 0m, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, 0m, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
