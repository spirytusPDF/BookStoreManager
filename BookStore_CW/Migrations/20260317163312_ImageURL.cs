using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore_CW.Migrations
{
    /// <inheritdoc />
    public partial class ImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "PublishName",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "YearofPublish",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "PublishName",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "YearofPublish",
                table: "DefferedBooks");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "PublishName",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BooksOnSale");

            migrationBuilder.DropColumn(
                name: "YearofPublish",
                table: "BooksOnSale");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SoldBooks",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "DefferedBooks",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BooksOnSale",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksOnSale_Books_Id",
                table: "BooksOnSale",
                column: "Id",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DefferedBooks_Books_Id",
                table: "DefferedBooks",
                column: "Id",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoldBooks_Books_Id",
                table: "SoldBooks",
                column: "Id",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksOnSale_Books_Id",
                table: "BooksOnSale");

            migrationBuilder.DropForeignKey(
                name: "FK_DefferedBooks_Books_Id",
                table: "DefferedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldBooks_Books_Id",
                table: "SoldBooks");

            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SoldBooks",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "SoldBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "SoldBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "SoldBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SoldBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "SoldBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SoldBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PublishName",
                table: "SoldBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "SoldBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearofPublish",
                table: "SoldBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "DefferedBooks",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "DefferedBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "DefferedBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "DefferedBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DefferedBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "DefferedBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "DefferedBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PublishName",
                table: "DefferedBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "DefferedBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearofPublish",
                table: "DefferedBooks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BooksOnSale",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "BooksOnSale",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "BooksOnSale",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "BooksOnSale",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BooksOnSale",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "BooksOnSale",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BooksOnSale",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PublishName",
                table: "BooksOnSale",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "BooksOnSale",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearofPublish",
                table: "BooksOnSale",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
