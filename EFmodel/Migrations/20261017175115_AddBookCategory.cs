using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFmodel.Migrations
{
    /// <inheritdoc />
    public partial class AddBookCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookCategoryId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookCategoryId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                column: "BookCategoryId");

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
                name: "FK_Books_BookCategories_BookCategoryId",
                table: "Books",
                column: "BookCategoryId",
                principalTable: "BookCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_BookCategories_BookCategoryId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategories_BookCategoryId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookCategoryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookCategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookCategoryId",
                table: "Authors");
        }
    }
}
