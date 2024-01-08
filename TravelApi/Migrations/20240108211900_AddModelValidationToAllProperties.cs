using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AddModelValidationToAllProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Message",
                keyValue: null,
                column: "Message",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Reviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Country",
                keyValue: null,
                column: "Country",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Reviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "City",
                keyValue: null,
                column: "City",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Reviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Author",
                keyValue: null,
                column: "Author",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Reviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Author",
                value: "Danny");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Author",
                value: "Jim");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Author",
                value: "Renton");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Author",
                value: "Benjamin");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Author",
                value: "Henry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Reviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Reviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Reviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Reviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Author",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Author",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Author",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Author",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Author",
                value: null);
        }
    }
}
