using GamePointDB.Entity;
using System.Text.Json.Serialization;

namespace GamePoint.WebAPI.Models
{
    public class ProductModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        [JsonPropertyName("category")]
        public Category Category { get; set; }
    }
}
