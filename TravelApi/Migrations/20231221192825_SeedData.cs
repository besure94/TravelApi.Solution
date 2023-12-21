using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "TravelDestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "TravelDestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "TravelDestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "TravelDestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "TravelDestinationId",
                keyValue: 5);
        }
    }
}
