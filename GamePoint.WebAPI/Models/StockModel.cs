using GamePointDB.Entity;
using System.Text.Json.Serialization;

namespace GamePoint.WebAPI.Models
{
    public class StockModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("movementType")]
        public string MovementType { get; set; }

        [JsonPropertyName("movementDate")]
        public DateTime MovementDate { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }
    }
}
