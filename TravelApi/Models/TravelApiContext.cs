using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Review> Reviews { get; set; }
    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, City = "Dublin", Country = "Ireland", Message = "Beautiful and friendly! Will visit again.", Rating = 10, Author = "Danny" },
          new Review { ReviewId = 2, City = "St Louis", Country = "United States", Message = "Historic and walkable but very dirty.", Rating = 4, Author = "Jim" },
          new Review { ReviewId = 3, City = "Cairo", Country = "Egypt", Message = "Great attractions and history. Crowded and smoggy.", Rating = 8, Author = "Renton" },
          new Review { ReviewId = 4, City = "Puerto Vallarta", Country = "Mexico", Message = "Beautiful, relaxing and warm.", Rating = 9, Author = "Benjamin" },
          new Review { ReviewId = 5, City = "Shanghai", Country = "China", Message = "Diverse, lots of entertainment, great food.", Rating = 8, Author = "Henry" }
      );
    }
  }
}