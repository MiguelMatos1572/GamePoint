using Azure.Core;
using GamePoint.WebAPI.Models;
using GamePointDB.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamePoint.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly BusinessContext _businessContext;

        public StockController(BusinessContext businessContext)
        {
            _businessContext = businessContext;
        }

        [HttpGet("/getproducts")]
        public async Task<IActionResult> GetProducts()
        {
            var taskTable = await _businessContext.Products.ToListAsync();

            return Ok(taskTable);
        }

        [HttpPut("updatestock")]
        public async Task<IActionResult> UpdateStock(StockModel stockModel)
        {
            var stock = await _businessContext.Stocks.FirstOrDefaultAsync(p => p.Id.Equals(stockModel.Id));

            if (stock is null)
                return BadRequest();

            stock.MovementType = stockModel.MovementType;
            stock.Quantity = stockModel.Quantity;
            stock.MovementDate = DateTime.Now;

            var result = await _businessContext.SaveChangesAsync();

            if (result.Equals(1))
                return Ok();

            return BadRequest();
        }
    }
}
