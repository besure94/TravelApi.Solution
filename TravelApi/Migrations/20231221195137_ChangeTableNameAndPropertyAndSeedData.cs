using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class ChangeTableNameAndPropertyAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelDestinations");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfReviews = table.Column<int>(type: "int", nullable: false),
                    OverallRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Message", "NumberOfReviews", "OverallRating" },
                values: new object[,]
                {
                    { 1, "Dublin", "Ireland", "Beautiful and friendly! Will visit again.", 234, 10 },
                    { 2, "St Louis", "United States", "Historic and walkable but very dirty.", 43, 4 },
                    { 3, "Cairo", "Egypt", "Great attractions and history. Crowded and smoggy.", 435, 7 },
                    { 4, "Puerto Vallarta", "Mexico", "Beautiful, relaxing and warm.", 128, 9 },
                    { 5, "Shanghai", "China", "Diverse, lots of entertainment, great food.", 879, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.CreateTable(
                name: "TravelDestinations",
                columns: table => new
                {
                    TravelDestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfReviews = table.Column<int>(type: "int", nullable: false),
                    OverallRating = table.Column<int>(type: "int", nullable: false),
                    Reviews = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelDestinations", x => x.TravelDestinationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TravelDestinations",
                columns: new[] { "TravelDestinationId", "City", "Country", "NumberOfReviews", "OverallRating", "Reviews" },
                values: new object[,]
                {
                    { 1, "Dublin", "Ireland", 234, 10, "Beautiful and friendly! Will visit again." },
                    { 2, "St Louis", "United States", 43, 4, "Historic and walkable but very dirty." },
                    { 3, "Cairo", "Egypt", 435, 7, "Great attractions and history. Crowded and smoggy." },
                    { 4, "Puerto Vallarta", "Mexico", 128, 9, "Beautiful, relaxing and warm." },
                    { 5, "Shanghai", "China", 879, 10, "Diverse, lots of entertainment, great food." }
                });
        }
    }
}
