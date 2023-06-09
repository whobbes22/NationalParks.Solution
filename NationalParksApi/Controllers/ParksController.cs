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

    // GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkName, string parkType, string parkLocation, string parkSize, string parkDescription)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();
      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }

      if (parkType != null)
      {
        query = query.Where(entry => entry.ParkType == parkType);
      }

      if (parkLocation != null)
      {
        query = query.Where(entry => entry.ParkLocation == parkLocation);
      }

      if (parkSize != null)
      {
        query = query.Where(entry => entry.ParkSize == parkSize);
      }

      if (parkDescription != null)
      {
        query = query.Where(entry => entry.ParkDescription == parkDescription);
      }
      return await query.ToListAsync();
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