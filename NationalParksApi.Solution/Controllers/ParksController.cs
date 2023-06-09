using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI.Models;
using System.Linq;

namespace ParksAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private readonly NationalParkContext _db;

    public ReviewsController(NationalParkContext db)
    {
      _db = db;
    }

    // GET: api/Reviews/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetReview(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }



  }
}