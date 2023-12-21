namespace TravelApi.Models
{
  public class TravelDestination
  {
    public int TravelDestinationId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Reviews { get; set; }
    public int NumberOfReviews { get; set; }
    public int OverallRating { get; set; }
  }
}