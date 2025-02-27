using System.Text.Json.Serialization;

namespace GamePoint.WebAPI.Models
{
    public class ImageModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        public int ProductId { get; set; }
    }
}
