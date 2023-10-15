using buyC.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace buyC.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _db;

        public ProductController(DataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetShoes()
        {
            var shoes = _db.Shoes.ToList();

            return Ok(shoes);
        }

        [HttpGet("new")]
        public async Task<IActionResult> GetNewArrivals()
        {
            try
            {
                var shoes = await _db.Shoes
                    .OrderByDescending(x => x.Date)
                    .Take(5)
                    .ToListAsync();

                if (shoes.Count == 0)
                {
                    // If there are no new arrivals, return a 404 Not Found response.
                    return NotFound();
                }

                return Ok(shoes);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately.
                return StatusCode(500, "An error occurred while fetching new arrivals.");
            }
        }
    }
}
