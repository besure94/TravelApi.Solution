using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class RemoveNumberOfReviewsAndOverallRatingProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfReviews",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "OverallRating",
                table: "Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfReviews",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OverallRating",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "NumberOfReviews", "OverallRating" },
                values: new object[] { 234, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                columns: new[] { "NumberOfReviews", "OverallRating" },
                values: new object[] { 43, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                columns: new[] { "NumberOfReviews", "OverallRating" },
                values: new object[] { 435, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                columns: new[] { "NumberOfReviews", "OverallRating" },
                values: new object[] { 128, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                columns: new[] { "NumberOfReviews", "OverallRating" },
                values: new object[] { 879, 10 });
        }
    }
}
