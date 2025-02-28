
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GamePointDB.Data;
using GamePointDB.Entity;
using GamePoint.WebAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace GamePoint.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly BusinessContext _businessContext;

        public ProductController(BusinessContext businessContext)
        {
            _businessContext = businessContext;
        }


        [HttpGet("/getproducts")]
        public async Task<IActionResult> GetProducts()
        {
            var taskTable = await _businessContext.Products.Include(x => x.Image).Include(x => x.Category).ToListAsync();

            return Ok(taskTable);
        }
        
        [HttpGet("/getproduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var taskTable = await _businessContext.Products.FirstOrDefaultAsync(t => t.IsDeleted == false && t.Id.Equals(id));

            if (taskTable is null)
                return NotFound();

            else
                return Ok(taskTable);
        }

        [HttpPost("/addproducts")]
        public async Task<IActionResult> AddTask(ProductModel productModel)
        {
            var product = await _businessContext.Products.FirstOrDefaultAsync(t => t.Id.Equals(productModel.Id));

            if (product is not null)
                return BadRequest();

            var newProduct = new GamePointDB.Entity.Product();
            newProduct.Name = productModel.Name;
            newProduct.Description = productModel.Description;
            newProduct.Price = productModel.Price;
            newProduct.CategoryId = productModel.CategoryId;

            _businessContext.Products.Add(newProduct);

            var result = await _businessContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("/deleteproduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _businessContext.Products.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if (product is null)
                return BadRequest();

            product.IsDeleted = true;

            var result = await _businessContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest();
        }

        [HttpPut("/updateproduct")]
        public async Task<IActionResult> UpdateProduct(ProductModel productModel)
        {
            var product = await _businessContext.Products.FirstOrDefaultAsync(t => t.Id.Equals(productModel.Id));

            if (product is null)
                return BadRequest();

            product.Name = productModel.Name;
            product.Description = productModel.Description;
            product.Price = productModel.Price;

            var result = await _businessContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest();
        }
    }
}
