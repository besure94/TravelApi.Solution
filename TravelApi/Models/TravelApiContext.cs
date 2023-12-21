using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<TravelDestination> TravelDestinations { get; set; }
    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {

    }
  }
}