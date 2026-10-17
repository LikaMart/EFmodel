using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFmodel.Migrations
{
    /// <inheritdoc />
    public partial class FixAuthorAndBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_BookCategories_BookCategoryId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavoriteBooks_Authors_AuthorId",
                table: "UserFavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserFavoriteBooks_AuthorId",
                table: "UserFavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookCategoryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "UserFavoriteBooks");

            migrationBuilder.DropColumn(
                name: "BookCategoryId",
                table: "Authors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "UserFavoriteBooks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookCategoryId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteBooks_AuthorId",
                table: "UserFavoriteBooks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookCategoryId",
                table: "Authors",
                column: "BookCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_BookCategories_BookCategoryId",
                table: "Authors",
                column: "BookCategoryId",
                principalTable: "BookCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavoriteBooks_Authors_AuthorId",
                table: "UserFavoriteBooks",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");
        }
    }
}
