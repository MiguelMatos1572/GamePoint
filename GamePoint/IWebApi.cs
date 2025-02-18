using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GamePoint.WebAPI.Models;
using Refit;
using GamePointDB.Entity;
using GamePointDB.Data;

namespace GamePoint.WebAplication
{
    public interface IWebApi
    {
        [Get("/getproduct")]
        Task<List<ProductModel>> GetProduct();

        [Post("/addProducts")]
        Task<HttpResponseMessage> AddProduct([FromBody] GamePoint.WebAPI.Models.ProductModel productModel);

        [Delete("/deleteproduct")]
        Task<HttpResponseMessage> DeleteProduct(long id);
    }
}
