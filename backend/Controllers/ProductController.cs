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
        public async Task<IActionResult> GetShoes(bool isNew, bool isFeatured)
        {
            // var shoes = _db.Shoes.ToList();
            try
            {
                // Look at what As Queryable returns
                var shoes = _db.Shoes.AsQueryable();
                
                // if (!isNew && !isFeatured)
                // {
                //     
                //     return Ok(shoes.ToListAsync());
                // }

                if (isNew)
                {
                    isFeatured = false;
                    await shoes.OrderByDescending(x => x.Date)
                        .Take(5)
                        .ToListAsync();
                }

                if (isFeatured)
                {
                    isNew = false;
                    await shoes.Where(x => x.IsFeatured == true)
                        .ToListAsync();
                }

                return Ok(shoes);
            }
            catch (Exception e)
            {
                return StatusCode(500, "An error occured while fetching results");
            }
        }
        
    }
}
