using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DI_DemowebAPI.Models.EF;

namespace DI_DemowebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private readonly ProductManagementContext _context;

        public productsController(ProductManagementContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsInfo>>> GetProductsInfos()
        {
          if (_context.ProductsInfos == null)
          {
              return NotFound();
          }
            return await _context.ProductsInfos.ToListAsync();
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsInfo>> GetProductsInfo(int id)
        {
          if (_context.ProductsInfos == null)
          {
              return NotFound();
          }
            var productsInfo = await _context.ProductsInfos.FindAsync(id);

            if (productsInfo == null)
            {
                return NotFound();
            }

            return productsInfo;
        }

        // PUT: api/products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductsInfo(int id, ProductsInfo productsInfo)
        {
            if (id != productsInfo.PId)
            {
                return BadRequest();
            }

            _context.Entry(productsInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsInfoExists(id))
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

        // POST: api/products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductsInfo>> PostProductsInfo(ProductsInfo productsInfo)
        {
          if (_context.ProductsInfos == null)
          {
              return Problem("Entity set 'ProductManagementContext.ProductsInfos'  is null.");
          }
            _context.ProductsInfos.Add(productsInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductsInfoExists(productsInfo.PId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductsInfo", new { id = productsInfo.PId }, productsInfo);
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductsInfo(int id)
        {
            if (_context.ProductsInfos == null)
            {
                return NotFound();
            }
            var productsInfo = await _context.ProductsInfos.FindAsync(id);
            if (productsInfo == null)
            {
                return NotFound();
            }

            _context.ProductsInfos.Remove(productsInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductsInfoExists(int id)
        {
            return (_context.ProductsInfos?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}
