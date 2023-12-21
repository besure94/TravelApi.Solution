namespace TravelApi.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Message { get; set; }
    public int NumberOfReviews { get; set; }
    public int OverallRating { get; set; }
  }
}