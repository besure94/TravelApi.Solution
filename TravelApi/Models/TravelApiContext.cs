using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<TravelDestination> TravelDestinations { get; set; }
    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<TravelDestination>()
        .HasData(
          new TravelDestination { TravelDestinationId = 1, City = "Dublin", Country = "Ireland", Reviews = "Beautiful and friendly! Will visit again.", NumberOfReviews = 234, OverallRating = 10 },
          new TravelDestination { TravelDestinationId = 2, City = "St Louis", Country = "United States", Reviews = "Historic and walkable but very dirty.", NumberOfReviews = 43, OverallRating = 4 },
          new TravelDestination { TravelDestinationId = 3, City = "Cairo", Country = "Egypt", Reviews = "Great attractions and history. Crowded and smoggy.", NumberOfReviews = 435, OverallRating = 7 },
          new TravelDestination { TravelDestinationId = 4, City = "Puerto Vallarta", Country = "Mexico", Reviews = "Beautiful, relaxing and warm.", NumberOfReviews = 128, OverallRating = 9 },
          new TravelDestination { TravelDestinationId = 5, City = "Shanghai", Country = "China", Reviews = "Diverse, lots of entertainment, great food.", NumberOfReviews = 879, OverallRating = 10}
      );
    }
  }
}