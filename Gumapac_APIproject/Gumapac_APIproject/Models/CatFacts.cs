using System.Text.Json.Serialization;

namespace GumapacAPIproject.Models
{
    public class CatFacts
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; } = "";

        [JsonPropertyName("length")]
        public string Length { get; set; }
    }
}

