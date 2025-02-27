using System.Text.Json.Serialization;

namespace GamePoint.WebAPI.Models
{
    public class CategoryModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
