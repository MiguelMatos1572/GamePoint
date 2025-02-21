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
        [Get("/getproducts")]
        Task<List<ProductModel>> GetProducts();

        [Get("/getproduct")]
        Task<ProductModel> GetProduct(int id);

        [Post("/addProducts")]
        Task<HttpResponseMessage> AddProduct([FromBody] GamePoint.WebAPI.Models.ProductModel productModel);

        [Delete("/deleteproduct")]
        Task<HttpResponseMessage> DeleteProduct(long id);

        [Put("/updateproduct")]
        Task<HttpResponseMessage> UpdateProduct([FromBody] ProductModel productModel);
    }
}
