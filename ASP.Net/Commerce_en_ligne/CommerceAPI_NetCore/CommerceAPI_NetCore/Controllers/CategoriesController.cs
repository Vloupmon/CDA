using CommerceAPI_NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceAPI_NetCore.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase {
        private readonly EcommerceSimplifieContext _context;

        public CategoriesController(EcommerceSimplifieContext context) {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories() {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id) {
            var category = await _context.Categories.FindAsync(id);

            if (category == null) {
                return NotFound();
            }

            return category;
        }

        // GET: api/Categories/5/children
        [HttpGet("{id}/children")]
        public async Task<ActionResult<IEnumerable<Category>>> GetChildrenCategories(int id) {
            var categories = await _context.Categories.Where(x => x.ParentCategoryId == id).ToListAsync();
            if (categories == null) {
                return NotFound();
            }
            return categories;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category) {
            if (id != category.Id) {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!CategoryExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        // GET: api/Categories/5/products/2
        [HttpGet("{id}/products/{page}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsOfCategory(int id, int page) {
            var category = await _context.Categories.FindAsync(id);

            if (category == null) {
                return NotFound();
            }

            List<Product> products = await (from map in _context.ProductCategoryMappings
                                            join cat in _context.Categories on map.CategoryId equals cat.Id
                                            join prod in _context.Products on map.ProductId equals prod.Id
                                            where map.CategoryId == id
                                            select map
                                  )
                                  .Skip(category.PageSize * (page - 1))
                                  .Take(category.PageSize)
                                  .Select(p => p.Product)
                                  .ToListAsync();

            if (products == null || products.Count == 0) {
                return NotFound();
            }

            return products;
        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category) {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new {
                id = category.Id
            }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id) {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(int id) {
            return _context.Categories.Any(e => e.Id == id);
        }

        // GET: api/Categories/5/picture
        [HttpGet("{id}/picture")]
        public async Task<ActionResult<Picture>> GetPictureById(int id) {
            var picture = await (from pic in _context.Pictures
                                 join cat in _context.Categories on pic.Id equals cat.PictureId
                                 select pic)
                                 .Where(x => x.Id == id)
                                 .FirstOrDefaultAsync();

            if (picture == null) {
                return NotFound();
            }

            return picture;
        }
    }
}