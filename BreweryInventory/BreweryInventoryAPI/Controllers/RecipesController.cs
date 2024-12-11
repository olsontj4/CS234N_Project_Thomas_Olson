using BreweryInventoryEFClasses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BreweryInventoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly BreweryInventoryContext _context;
        public RecipesController(BreweryInventoryContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
        {
            if (_context.Recipes == null)
            {
                return NotFound();
            }
            return await _context.Recipes.ToListAsync();
        }
    }
}