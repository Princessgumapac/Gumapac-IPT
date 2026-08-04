using System.Net.Http.Json;
using System.Text.Json.Serialization;
namespace GumapacAPIproject.Models
{

    public class CatImage
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }

}
