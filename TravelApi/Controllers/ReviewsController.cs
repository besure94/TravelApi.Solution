using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public ReviewsController(TravelApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> Get(string city, string country, int rating)
    {
      IQueryable<Review> query = _db.Reviews.AsQueryable();

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating >= rating).OrderByDescending(entry => entry.Rating);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Review>> GetReview(int id)
    {
      Review review = await _db.Reviews.FindAsync(id);

      if (review == null)
      {
        return NotFound();
      }

      return review;
    }

    [HttpPost]
    public async Task<ActionResult<Review>> Post(Review review)
    {
      _db.Reviews.Add(review);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetReview), new { id = review.ReviewId }, review);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, string author, Review review)
    {
      if (id != review.ReviewId)
      {
        return BadRequest();
      }

      if (author.ToLower() != review.Author.ToLower())
      {
        return BadRequest();
      }

      _db.Reviews.Update(review);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ReviewExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private bool ReviewExists(int id)
    {
      return _db.Reviews.Any(entry => entry.ReviewId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReview(int id, string author)
    {
      Review review = await _db.Reviews.FindAsync(id);
      if (review == null)
      {
        return NotFound();
      }

      if (author.ToLower() != review.Author.ToLower())
      {
        return BadRequest();
      }

      _db.Reviews.Remove(review);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}