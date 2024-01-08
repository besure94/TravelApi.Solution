using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Review
  {
    public int ReviewId { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string Country { get; set; }

    [Required]
    public string Message { get; set; }

    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
    public int Rating { get; set; }

    [Required]
    public string Author { get; set; }
  }
}