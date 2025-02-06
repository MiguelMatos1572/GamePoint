using GamePoint.WebAPI.Models;
using Refit;

namespace GamePoint.WebAplication
{
    public interface IWebApi
    {
        [Get("/getproducts")]
        Task<List<ProductModel>> GetProducts();

        [Put("/updatestock")]
        Task<List<StockModel>> UpdateStock();
    }
}
