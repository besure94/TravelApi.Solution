using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Message { get; set; }

    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
    public int Rating { get; set; }
    public string Author { get; set; }
  }
}